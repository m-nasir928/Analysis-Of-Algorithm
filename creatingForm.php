<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title></title>
</head>
<body>
//get input from user.
<form action="creatingForm.php" method="get">
	Name:<input type="text" name="username">
	<br>
	Age:<input type="text" name="age">
	<input type="submit">
</form>
<br>
Your name is<?php echo $_GET["username"] ?>
<br>
Your age is<?php echo $_GET["age"] ?>
</body>
</html>
