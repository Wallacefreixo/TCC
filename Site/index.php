<?php

	session_start();
	if($_SESSION['LOGOU'] !="OK")
	{
		$_SESSION['msg']="ERRO! Você deve logar antes!";
		header('Location:form_login.html');
	}
	echo "<html>";
	echo "<head>";
	echo "<body link='#000000' vlink='#321c40' alink='#FFFFFF'>";
	echo "<meta charset='utf-8'/>";
	echo"<title>&Aacuterea do Cliente</title>";
  
    echo"<link rel='stylesheet'  href='style.css'>";
    echo"<link rel='stylesheet' href='css/bootstrap.css'>";
	echo "<link rel='stylesheet' href='cssmenu/styles.css'>";
	echo "<script src='http://code.jquery.com/jquery-latest.min.js' type='text/javascript'></script>";
	echo "<script src='cssmenu/script.js'></script>";
	
    echo"</head>";

    echo"<br>";
    echo"<h1><span class='blue'><img src='assets\img\logo.png'  width='100px' align='center'/><br></span>";
    echo"<span class='blue'></span><span class='yellow'></span></h1>";
	echo"<body>";
	
	/*Menu Começa Aqui*/
	echo"<CENTER><div id='cssmenu'>";
	echo"<ul>";
    echo"<li><a href='#'><span> Consulta</span></a></li>";
	echo"<li><a href='laudo.php'><span>Laudo</span></a></li>";
    echo"<li><a href='receituario.php'><span>Receituário</span></a>";
    echo"</li>";
    echo"<li class='last'><a href='sair.php'><span>SAIR</span></a></li>";
	echo"</ul>";
	echo"</div>";
	echo "<br>";
	echo "<br>";

include('conexaobanco.php');

$user=$_SESSION['use'];

//pega o código do paciente
$statmt = sqlsrv_query($conn, "SELECT Id from Paciente where Usuario = '$user';");
while($result = sqlsrv_fetch_array($statmt)){
$aux=$result['Id'];
}
	


//monta a tabela
echo "<table class='container'>";
echo "Seja bem-vindo a tela de consultas";
echo"<br>";
echo "Paciente: $user";	
echo"<br>";
echo "<br>";

//Gráfico
echo"<h4>Gráficos</h4>";
echo "<div id='piechart' style='width: 400px; height: 200px;'></div>";
echo"<br>";
echo"<h4>Relatórios</h4>";		
$sql2 = sqlsrv_query($conn, "SELECT Id from Consulta where IdPaciente='$aux';");
//testa se o usuario possui id cadastrados
if (sqlsrv_has_rows($sql2))
{			echo"<thead>";
		echo"<tr>";
			echo"<th><h1>ID</h1></th>";
			echo"<th><h1>Médico Responsável</h1></th>";
			echo"<th><h1>Data</h1></th>";
			echo"<th><h1>Horário</h1></th>";
			echo"<th><h1>Status</h1></th>";	
		echo"</tr>";
	echo"</thead>";
	

		$sql = sqlsrv_query($conn, "SELECT C.Id, E.Nome, C.Data, C.HorarioAtendimento, C.Status FROM Consulta AS C JOIN Especialista AS E ON C.IdMedico = E.Id Where  IdPaciente='$aux';");

		$cont_status_confirmadas = 0;
		$cont_status_realizadas  = 0;
		$cont_status_canceladas = 0;
		while ($result = sqlsrv_fetch_array($sql) )
		{
			echo '<tr>';
			echo "<td>".$result[0]."</td>";
			echo "<td>".$result[1]."</td>";
			echo "<td>".$result[2]."</td>";
			echo "<td>".$result[3]."</td>";
			if($result[4] == '0')
			{
			 echo "<td>Confirmada</td>";

			}
			else if( $result[4] =='1')
			{
				echo "<td>Cancelada</td>";

			}
			else if($result[4] =='2')
			{
				echo "<td>Realizada</td>";
			}
			echo '</tr>';

		if($result[4] == '0'){
			$cont_status_confirmadas++;

		}
		else if($result[4] == '1'){

			$cont_status_canceladas++;
		}
		else if($result[4] == '2'){
			$cont_status_realizadas++;
			
		}
	}
		
}		

	else
	{
		echo "<center><h2>Voc&ecirc; n&atilde;o possui dados cadastrados nessa página<h2></center>";
	}
	
echo "</table>";

echo "</body>";

echo"<script type='text/javascript' src='https://www.gstatic.com/charts/loader.js'></script>";
 echo"   <script type='text/javascript'>
      google.charts.load('current', {'packages':['corechart']});
      google.charts.setOnLoadCallback(drawChart);";

  echo" function drawChart() {

        var data = google.visualization.arrayToDataTable([
          ['Status', 'Quantidade'],
          ['Confirmadas',  $cont_status_confirmadas],
          ['Realizadas',   $cont_status_realizadas ],
          ['Canceladas',   $cont_status_canceladas ]
        ]);

        var options = {
          title: 'Status da consulta',
          colors: ['#B43126','#d14b3a', '#e0725e',],
          backgroundColor: '#FFDDC1',
        }; 

        var chart = new google.visualization.PieChart(document.getElementById('piechart'));

        chart.draw(data, options);
      }";
   echo" </script>";

echo "</html>";

?>
