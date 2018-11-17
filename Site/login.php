<?php
	
	
	
	
	session_start();
	
	// conectei com o banco
	include('conexaobanco.php');
	 
	$usuario = $_REQUEST['usuario'];
	$senha = $_REQUEST['senha'];
	$ativado=1;
	// montando a query
	
	$sql = sqlsrv_query($conn, "SELECT Usuario, Senha, Nome from Paciente where Usuario = '$usuario' AND Senha = '$senha';");
	echo "<font face='calibri'>";
	if (sqlsrv_has_rows($sql))
	{			
		       $_SESSION['LOGOU']="OK";
		       $_SESSION['use'] = $usuario;
		       $_SESSION['sen'] = $senha;
			   header('Location:index.php');
	}
	else
	{	
		
		
	  unset ($_SESSION['LOGOU']);
      echo "<script>location.href='erro-senha-login.html';</script>"; 


		
	}
?>