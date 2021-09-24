function verificar(){
    var ano = new Date()
    var anoAtual = ano.getFullYear()
    var anoRecebido = window.document.querySelector('input#idade')
    var res = window.document.querySelector('div#res')// --> CAIXA DE TEXTO

    if(Number(anoRecebido.value) === 0 || Number(anoRecebido.value) > anoAtual) {
        alert('[ERRO!]Digite os dados novamente.')
    } else{
        var idade = anoAtual - anoRecebido.value
        var sexoRecebido = window.document.getElementsByName('radsex')
        var genero = ''

        var img = window.document.createElement('img')
//              Criando uma tag <img>                   =================

        img.setAttribute('id', 'foto')
//              Colocando um atributo id="foto" na tag img  ==========

        if(sexoRecebido[0].checked) {
            genero = 'Homem'

            if(idade >= 0 && idade < 3){
                img.setAttribute('src', '/imagens/bebe-m.png')
//              Adicionando o atributo 'src' e adicionando as imagens

            } else if(idade < 11){
                img.setAttribute('src', '/imagens/crianca-m.png')
            } else if(idade < 20){
                img.setAttribute('src', '/imagens/adolescente-m.png')
            } else if(idade < 35){
                img.setAttribute('src', '/imagens/adulto-m.png')
            } else if(idade < 50){
                img.setAttribute('src', '/imagens/homem.png')
            } else{
                img.setAttribute('src', '/imagens/idoso-m.png')
            }
        } else if (sexoRecebido[1].checked){
            genero = 'Mulher'
            if(idade >= 0 && idade < 3){
                img.setAttribute('src', '/imagens/bebe-f.png')
            } else if(idade < 11){
                img.setAttribute('src', '/imagens/crianca-f.png')
            } else if(idade < 20){
                img.setAttribute('src', '/imagens/adolescente-f.png')
            } else if(idade < 35){
                img.setAttribute('src', '/imagens/adulto-f.png')
            } else if(idade < 50){
                img.setAttribute('src', '/imagens/mulher.png')
            } else{
                img.setAttribute('src', '/imagens/idoso-f.png')
            }
        }
        res.style.textAlign = 'center'
        res.innerHTML = `<p>Identificamos ${genero} com ${idade} anos.</p>`
        res.appendChild(img)//              -> Colocando a tag img pra mostrar =================

    }

}
 