<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/style.css">
    <title>Array</title>
</head>
<body>
    <h1>Criando Array</h1>
    <?php
        $array_um[] = "Testando";
        $array_um[] = "arrays";
        $array_um[] = "em";
        $array_um[] = "PHP";

        print_r($array_um);// -> Exibi valores e índices do array

        
        
        // ARRAYS ASSOCIATIVOS =======================
        $aluno = array();
        $aluno["Curso"] = "Téc. em Análise e Desenv. de Sistemas";
        $aluno["Nome"] = "Fernanda Albuquerque";
        $aluno["RA"] = "147258963";
        // OU
        $alunoDois = array(
           "Curso" => "Téc. em Análise e Desenv. de Sistemas",
           "Nome" => "Layra Reis",
           "RA" => "548745965"
        );

        // EXIBINDO OS VALORES DO ARRAY ASSOCIATIVO ====================
        echo("<hr>Dados do Aluno: " . 
        "<br><strong>Nome: </strong>" . $aluno['Nome'] . 
        "<br><strong>Curso: </strong>" . $aluno['Curso'] . 
        "<br><strong>RA: </strong>" . $aluno['RA']
        );

        echo("<hr>Dados do Aluno: " . 
        "<br><strong>Nome: </strong>" . $alunoDois["Nome"] . 
        "<br><strong>Curso: </strong>" . $alunoDois["Curso"] . 
        "<br><strong>Curso: </strong>" . $alunoDois["RA"] 
        );


        // ARRAYS MULTIDIMENSIONAIS(MATRIZES)
        $alunosTres = array(
            "TADS" => array(
                "descricao" => "Téc. em Análise e Desenv. de Sistemas",
                "disciplina" => "Programação Web"),
            "TSIN" => array(
                "descricao" => "Téc. em Sistemas para Internet", "disciplina" => "Comércio Eletrônico"),
            "SI" => array(
                "descricao" => "Sistemas de Informação",
                "disciplina" => "Design de Interface")
        );

        echo(
            "<hr>" .
            "Cursos e Disciplinas" . 
            
            "<br><br><strong>Sigla: </strong> TADS" . 
            "<br><strong>Descrição: </strong>" . $alunosTres["TADS"]["descricao"] . 
            "<br><strong>Disciplina: </strong>" . $alunosTres["TADS"]["disciplina"] . 

            "<br><br><strong>Sigla: </strong> TSIN" . 
            "<br><strong>Descrição: </strong>" . $alunosTres["TSIN"]["descricao"] . 
            "<br><strong>Disciplina: </strong>" . $alunosTres["TSIN"]["disciplina"] . 

            "<br><br><strong>Sigla: </strong> SI" . 
            "<br><strong>Descrição: </strong>" . $alunosTres["SI"]["descricao"] . 
            "<br><strong>Disciplina: </strong>" . $alunosTres["SI"]["disciplina"]
        );
    ?>
</body>
</html>