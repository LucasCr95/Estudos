var atual = new Date()      // Pegando dados do servidor
var diaSe = atual.getDay()  // PEGANDO DIA DA SEMANA =========
console.log(`Dia da semana: ${diaSe}`)

switch(diaSe){
    case 0: 
        cosole.log('Domingo')
        break
    case 1: 
        console.log('Segunda-feira')
        break
    case 2: 
        console.log('Terça-feira')
        break
    case 3: 
        console.log('Quarta-feira')
        break
    case 4: 
        console.log('Quinta-feira')
        break
    case 5: 
        console.log('Sexta-feira')
        break
    case 6: 
        console.log('Sábado')
        break
}