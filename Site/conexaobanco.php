 <?php
	
	$serverName = "azuretcc.database.windows.net"; //serverName\instanceName
$connectionInfo = array( "Database"=>"bancodados", "UID"=>"wallace", "PWD"=>"#Tccprojeto1");
$conn = sqlsrv_connect( $serverName, $connectionInfo);

if( $conn ) {
     
}else{
     die("Não foi possível abrir a conexao, tente novamente!");
}
?>