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
    echo"<li><a href='index.php'><span> Consulta</span></a></li>";
	echo"<li><a href='#'><span>Laudo</span></a></li>";
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
	

//pesquisa os id pelo codigo do paciente

		
//monta a tabela
echo "<table class='container'>";
echo "Laudos realizados";	
echo"<br>";
echo "<br>";
//Gráfico
echo"<h4>Gráficos</h4>";
echo "<div id='piechart' style='width: 500px; height: 200px;'></div>";
echo"<br>";
echo"<h4>Relatórios</h4>";
$sql2 = sqlsrv_query($conn, "SELECT Id from Consulta where IdPaciente='$aux';");
//testa se o usuario possui id cadastrados
if (sqlsrv_has_rows($sql2))
{			echo"<thead>";
		echo"<tr>";
			echo"<th><h1>ID</h1></th>";
			echo"<th><h1>Médico Responsável</h1></th>";
			echo"<th><h1>Exame</h1></th>";
			echo"<th><h1>Data</h1></th>";
			echo"<th><h1>Observações</h1></th>";	
		echo"</tr>";
	echo"</thead>";
	

		$sql = sqlsrv_query($conn, " SELECT Laudo.Id, Especialista.Nome, Exame.Nome, Laudo.Data, Laudo.Obs FROM Laudo INNER JOIN Consulta ON Laudo.IdConsulta = Consulta.Id AND Laudo.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id INNER JOIN Exame ON Laudo.IdExame = Exame.Id Where Consulta.IdPaciente='$aux';");

		$cont_hemograma = 0;
		$cont_colesterol = 0;
		$cont_mamografia = 0;
		$cont_eletrocard = 0;
		$cont_tireoide = 0;
		$cont_psa = 0;
		$cont_glicemia = 0;
		$cont_ecodo = 0;
		$cont_examepele = 0;
		$cont_testeergometrico = 0;
		while ($result = sqlsrv_fetch_array($sql) )
		{
			echo '<tr>';
			echo "<td width='40px'>".$result[0]."</td>";
			echo "<td width='60px'>".$result[1]."</td>";
			echo "<td width='180px'>".$result[2]."</td>";
			echo "<td width='120px'>".$result[3]."</td>";
			echo "<td width='400px'>".$result[4]."</td>";
			echo '</tr>';


	    if($result[2] == 'Hemograma'){
			$cont_hemograma++;

		}
		else if($result[2] == 'Colesterol'){

			$cont_colesterol++;
		}
		else if($result[2] == 'Mamografia'){
			$cont_mamografia++;
			
		}
		else if($result[2] == 'Eletrocardiograma'){
			$cont_eletrocard++;
			
		}
		else if($result[2] == 'Tireoide'){
			$cont_tireoide++;
			
		}
		else if($result[2] == 'PSA'){
			$cont_psa++;
			
		}
		else if($result[2] == 'Glicemia em jejum'){
			$cont_glicemia++;
			
		}
		else if($result[2] == 'Ecodopplercardiograma'){
			$cont_ecodo++;
			
		}
		else if($result[2] == 'Exame pele'){
			$cont_examepele++;
			
		}
		else if($result[2] == 'Teste Ergometrico'){
			$cont_testeergometrico++;
			
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
          ['Exame', 'Quantidade'],
          ['Hemograma',  $cont_hemograma],
          ['Colesterol',   $cont_colesterol ],
          ['Mamografia',   $cont_mamografia ],
          ['Eletrocardiograma',  $cont_eletrocard],
          ['Tireoide',   $cont_tireoide ],
          ['PSA',  $cont_psa],
          ['Glicemia em jejum',   $cont_glicemia ],
          ['Ecodopplercardiograma',  $cont_ecodo],
          ['Exame Pele',   $cont_examepele ],
          ['Teste Ergométrico',   $cont_testeergometrico ]
        ]);

        var options = {
          title: 'Total exames realizados',
          colors: ['#bf1517','#b43126','#a94233','#d14b3a', '#e0725e','#ed9684', '#9c4e41', '#8e594e','#7e625c', '#6a6a6a'],
          backgroundColor: '#FFDDC1',
        }; 

        var chart = new google.visualization.PieChart(document.getElementById('piechart'));

        chart.draw(data, options);
      }";
   echo" </script>";

echo "</html>";

echo "</html>";

?>
