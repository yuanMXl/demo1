<?php
header("content-type:text/html;charset=utf-8");
?>
<?php
header("Content-Type:image/png");//图片编码设置
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <div>
        <?php
            $folder = "E:/ymx";
            $files = array();
            $handle = opendir($folder);
            while(false!==($file=readdir($handle))){
                if($file!='.' && $file!='..'){
                    $hz=strstr($file,".");
                    if($hz==".jpg" or $hz==".JPEG")
                    {$files[]=$file;}  
                }
            }
            if($files){
                foreach($files as $k=>$v){
                    echo '<img width="200" height="200" src="'.$folder."/".$v.'">';
                }
            }
        ?>
        
    </div>
</body>
</html>