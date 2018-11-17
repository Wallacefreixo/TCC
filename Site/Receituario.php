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
	echo"<li><a href='laudo.php'><span>Laudo</span></a></li>";
    echo"<li><a href='#'><span>Receituário</span></a>";
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
echo "Receituários realizados";
echo "<br>";
echo "<br>";

//Gráfico
echo"<h4>Gráficos</h4>";
echo "<div id='piechart' style='width: 500px; height: 200px;'></div>";
echo "<br>";
echo "<div id='piechart2' style='width: 500px; height: 200px;'></div>";
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
			echo"<th><h1>Observações</h1></th>";
			echo"<th><h1>Exames</h1></th>";	
			echo"<th><h1>Medicamentos</h1></th>";		
		echo"</tr>";
	echo"</thead>";
	

		$sql = sqlsrv_query($conn, " SELECT Receituario.Id, Especialista.Nome, Receituario.Data, Receituario.Obs FROM Receituario INNER JOIN Consulta ON Receituario.IdConsulta = Consulta.Id INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.Id INNER JOIN Especialista ON Consulta.IdMedico = Especialista.Id Where Consulta.IdPaciente='$aux';");

		$cont_ibuprofeno = 0;
		$cont_dipirona = 0;
		$cont_cimetida = 0;
		$cont_paracetamol = 0;
		$cont_amitriptina = 0;
		$cont_bamifilina = 0;
		$cont_codeina = 0;
		$cont_cliprofloxacino = 0;
		$cont_cefepina = 0;
		$cont_metroclopramida = 0;

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
			echo "<td width='70px'>".$result[0]."</td>";
			echo "<td width='40px'>".$result[1]."</td>";
			echo "<td width='150px'>".$result[2]."</td>";
			echo "<td width='650px'>".$result[3]."</td>";

			//pega id do receituário
			$valor = $result[0];

			//verifica se existe exame
			$exame = sqlsrv_query($conn, "SELECT IdReceituario,IdExame from HistoricoExame where IdReceituario='$valor'");

			if (sqlsrv_has_rows($exame))
			{
			    echo "<td bgcolor='#EC605B' width='10px'><a href = exibirexame.php?id=".$valor.">Visualizar</td>";

				$sqlExame= sqlsrv_query($conn, "SELECT Exame.Id, Exame.Nome FROM  Receituario INNER JOIN HistoricoExame ON Receituario.Id = HistoricoExame.IdReceituario INNER JOIN Exame ON HistoricoExame.IdExame = Exame.Id Where HistoricoExame.IdReceituario ='$valor';");

				// AUX recebe um vetor do sqlExame
				while ($auxmexame = sqlsrv_fetch_array($sqlExame) )
				{
					   if($auxmexame[1] == 'Hemograma'){
							$cont_hemograma++;

						}
						else if($auxmexame[1] == 'Colesterol'){

								$cont_colesterol++;
						}
						else if($auxmexame[1] == 'Mamografia'){
								$cont_mamografia++;
			
						}
						else if($auxmexame[1] == 'Eletrocardiograma'){
							$cont_eletrocard++;
			
						}
						else if($auxmexame[1] == 'Tireoide'){
							$cont_tireoide++;
			
						}
						else if($auxmexame[1] == 'PSA'){
								$cont_psa++;
			
						}
						else if($auxmexame[1] == 'Glicemia em jejum'){
							$cont_glicemia++;
			
							}
						else if($auxmexame[1] == 'Ecodopplercardiograma'){
							$cont_ecodo++;
			
						}
						else if($auxmexame[1] == 'Exame pele'){
							$cont_examepele++;
					
						}
						else if($auxmexame[1] == 'Teste Ergometrico'){
							$cont_testeergometrico++;
					
						}
				}


			}
			else 
			{
				echo "<td width=40px'>Não possui</td>";
			}

			//verifica se existe medicamento
			$medicamento = sqlsrv_query($conn, "SELECT IdReceituario,IdMedicamento, Intervalo, Duracao, Dosagem from HistoricoMedicamento  where IdReceituario='$valor'");

			if (sqlsrv_has_rows($medicamento))
			{
				echo "<td bgcolor='#EC605B width='10px'><a href = exibirmedicamento.php?id=".$valor.">Visualizar</td>";

				$sqlMedicamento= sqlsrv_query($conn, "SELECT Medicamento.Id, Medicamento.Nome,HistoricoMedicamento.Dosagem, HistoricoMedicamento.Intervalo, HistoricoMedicamento.Duracao FROM  Receituario INNER JOIN HistoricoMedicamento ON Receituario.Id = HistoricoMedicamento.IdReceituario INNER JOIN Medicamento ON HistoricoMedicamento.IdMedicamento = Medicamento.Id Where HistoricoMedicamento.IdReceituario ='$valor';");

				// AUX recebe um vetor do sqlExame
				while ($auxmedicamento = sqlsrv_fetch_array($sqlMedicamento) )
				{
					   if($auxmedicamento[1] == 'Ibuprofeno'){
							$cont_ibuprofeno++;

					    }
						else if($auxmedicamento[1] == 'Dipirona'){

								$cont_dipirona++;
						}
						else if($auxmedicamento[1] == 'Cimetidina'){
							   $cont_cimetida++;
			
						}
						else if($auxmedicamento[1] == 'Paracetamol'){
							$cont_paracetamol++;
			
						}
						else if($auxmedicamento[1] == 'Amitriptina'){
							$cont_amitriptina++;
			
							}
						else if($auxmedicamento[1] == 'Bamifilina'){
							$cont_bamifilina++;
							
						}
						else if($auxmedicamento[1] == 'Codeina'){
							$cont_codeina++;
					
						}
						else if($auxmedicamento[1] == 'CIiprofloxacino'){
							$cont_cliprofloxacino++;
				
						}
						else if($auxmedicamento[1] == 'Cefepina'){
							$cont_cefepina++;
			
						}
						else if($auxmedicamento[1] == 'Metroclopramida'){
							$cont_metroclopramida++;
			
						}
				}
			}
			else
			{
				echo "<td width='40px'> Não possui</td>";
			}

			echo '</tr>';


		
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

         var data2 = google.visualization.arrayToDataTable([
          ['Medicamento', 'Quantidade'],
          ['Ibuprofeno',  $cont_ibuprofeno],
          ['Dipirona',   $cont_dipirona ],
          ['Cimetidina',   $cont_cimetida ],
          ['Paracetamol',  $cont_paracetamol],
          ['Amitriptina',   $cont_amitriptina ],
          ['Bamifilina',  $cont_bamifilina],
          ['Codeina',   $cont_codeina ],
          ['Cliprofloxacino',  $cont_cliprofloxacino],
          ['Cefepina',   $cont_cefepina ],
          ['Metroclopramida',   $cont_metroclopramida ]
        ]);


        var options = {
          title: 'Total exames solicitados',
          colors: ['#bf1517','#b43126','#a94233','#d14b3a', '#e0725e','#ed9684', '#9c4e41', '#8e594e','#7e625c', '#6a6a6a'],
          backgroundColor: '#FFDDC1',
        }; 

         var options2 = {
          title: 'Total medicamentos solicitados',
          colors: ['#d14b3a','#bf1517','#b43126','#a94233', '#e0725e','#ed9684', '#9c4e41', '#8e594e','#7e625c', '#6a6a6a'],
          backgroundColor: '#FFDDC1',
        }; 


        var chart = new google.visualization.PieChart(document.getElementById('piechart'));
        chart.draw(data, options);     

        var chart2 = new google.visualization.PieChart(document.getElementById('piechart2'))
        chart2.draw(data2, options2);     


      }";

  
   echo" </script>";

echo "</html>";

?>
