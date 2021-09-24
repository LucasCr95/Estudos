var atual = new Date()  // Pegando dados do servidor
var hora = atual.getHours() // PEGANDO HORAS ===========
console.log(`Horário atual - ${hora}hrs.`)
if(hora < 12){
    console.log('Bom Dia!')
} else if(hora < 18){
    console.log('Boa Tarde!')
} else {
    console.log('Boa Noite!')
}