<?php

	session_start();
	if($_SESSION['LOGOU'] !="OK")
	{
		$_SESSION['msg']="ERRO! Você deve logar antes!";
		header('Location:form_login.html');
	}
	$aux = $_GET['id'];
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
    echo"<li><a href='receituario.php'><span>Receituário</span></a>";
    echo"</li>";
    echo"<li class='last'><a href='sair.php'><span>SAIR</span></a></li>";
	echo"</ul>";
	echo"</div>";
	echo "<br>";
	echo "<br>";
	echo "<br>";

include('conexaobanco.php');

echo "Voc&ecirc; est&aacute; vendo o hist&oacute;rico de medicamentos solicitados do Receituário: ";
echo $aux;
echo "<br>";
echo "<br>";

echo "<table class='container'>";
	echo "<br>";


$sql=sqlsrv_query($conn, "SELECT Medicamento.Id, Medicamento.Nome,HistoricoMedicamento.Dosagem, HistoricoMedicamento.Intervalo, HistoricoMedicamento.Duracao FROM  Receituario INNER JOIN HistoricoMedicamento ON Receituario.Id = HistoricoMedicamento.IdReceituario INNER JOIN Medicamento ON HistoricoMedicamento.IdMedicamento = Medicamento.Id Where HistoricoMedicamento.IdReceituario ='$aux';");
//testa se o usuario possui id cadastrados
if (sqlsrv_has_rows($sql))
{			echo"<thead>";
		echo"<tr>";
			echo"<th><h1>ID</h1></th>";
			echo"<th><h1>Nome</h1></th>";	
			echo"<th><h1>Dosagem</h1></th>";	
			echo"<th><h1>Intervalo</h1></th>";	
			echo"<th><h1>Duracao</h1></th>";		
		echo"</tr>";
	echo"</thead>";

		while ($result = sqlsrv_fetch_array($sql) )
		{
			echo '<tr>';
			echo "<td>".$result[0]."</td>";
			echo "<td>".$result[1]."</td>";
			echo "<td>".$result[2]."</td>";
			echo "<td>".$result[3]."</td>";
			echo "<td>".$result[4]."</td>";
			echo '</tr>';
	}
}		
	else
	{
		echo "<center><h2>Voc&ecirc; n&atilde;o possui dados cadastrados nessa página<h2></center>";
	}
	
echo "</table>";

echo "</body>";

echo "</html>";

?>
