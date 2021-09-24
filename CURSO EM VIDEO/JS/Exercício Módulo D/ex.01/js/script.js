function carregar() {
var msg = window.document.querySelector('div#msg')
var img = window.document.querySelector('img#imagem')
var date = new Date()
var hora = date.getHours()
msg.innerHTML = `Agora são ${hora} horas.`

if(hora >= 0 && hora < 12){
        //BOM DIA
        img.src = "/imagens/img-1.png"
        document.body.style.background = '#F0D0B2'
    } else if(hora < 18){
        //BOA TARDE
        img.src = '../imagens/img-2.png'
        document.body.style.background = '#214DA6'
    } else{
        //BOA NOITE
        img.src = '../imagens/img-3.png'
        document.body.style.background = '#202C46'
    }
}