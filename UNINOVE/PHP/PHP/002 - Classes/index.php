<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Classes</title>
</head>
<body>
    <h1>Trabalhando com classes</h1>
    <?php
        //CRIANDO CLASSE
        class Aluno{
            //ATRIBUTOS DA CLASSE
            public $nome;
            public $ra;
            public $endereco;

            //CONSTRUTOR DA CLASSE
            function aluno(){
                $this -> DadosAluno();
            }

            function DadosAluno(){
                $this -> nome = "Milena";
                $this -> ra = "745854";
                $this -> endereco = "Rua Martins Almeida, 161 - SP";
            }
        }

        $aluno = new Aluno();

        echo "<strong>Nome: </strong>" . $aluno -> nome . 
            "<br><strong>RA: </strong>" . $aluno -> ra . 
            "<br><strong>Endereço: </strong>" . $aluno -> endereco;


    ?>
</body>
</html>