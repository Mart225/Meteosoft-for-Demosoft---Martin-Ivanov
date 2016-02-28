<html>
<body>

<body background = "img.jpg">
<title>Meteosoft internet dash</title>
<center>
<font color="90EE90">
<font face="Microsoft Serif Sans, arial" size="3"><b>This WEB SERVER is hosted by Martin's MACBOOK.</b>
<br></br> 
<font face="Microsoft Serif Sans, arial" size="2"><b>Please type command and send it!</b>

<form action="index.php" method="POST">
<textarea rows="1" cols="20" style="font-family:Palatino, serif" name="quote" wrap="physical"></textarea>
<br>
</br>
<input type="hidden" name="turn" value="send" style="font-family:Palatino, serif" />
<input type="Submit" style="font-family:Palatino, serif" value="Send command...">
</form></p>


<?php
error_reporting( error_reporting() & ~E_NOTICE );

$prog = fopen("C:/wamp/www/cmd.txt", "w+");

$quote = $_POST['quote'];
if ($_POST['turn']=="send"){
fwrite($prog, $quote);
echo "Command: ";
echo "<i>$quote</i>";
echo " sent SUCCESSFULY! :)";
}
fclose($prog);
?>
<br></br>
<font face="Microsoft Serif Sans, arial" size="5"><b>MART225-ARDUINO SERIAL LOG</b>
</font>
<br>
<?php
$fr = fopen("C:/wamp/logs/SERIAL_LOG.txt", "r+");
$info = fread($fr, 100000);
$_POST["nfo"] = $info;
fclose($fr);
$value = "0";
?>

<textarea rows="30" cols="120" style="font-family:Palatino, serif" name="nfo" wrap="physical" readonly="">"<?php echo $_POST['nfo']; ?>"</textarea><br />
<br>
</br>

<form action="index.php" method="POST">
<input type="hidden" name="ref" value="refresh" />
<input type="Submit" style="font-family:Palatino, serif" value="Refresh the data...">
</form></p>

<form action="index.php" method="POST">
<input type="hidden" name="675" value="4788" />
<input type="Submit" style="font-family:Palatino, serif" value="Clear the LOG!">
<textarea rows="1" cols="18" style="font-family:Palatino, serif" name="com" wrap="physical"></textarea>
</form>

<font color = "000000">

<?php
$com = $_POST['com'];
if($_POST['675']=="4788"){
 if ($com=="сона е мрънкало"){
echo "PASSWORD ACEPTED,";
$fw = fopen("C:/wamp/logs/SERIAL_LOG.txt", "w+");
ftruncate($fw, 0);
echo " The LOG file CLEARED SUCCESSFULY, refresh to update the status!";
 }
}
?>

</font>
</center>
</body>
</html>