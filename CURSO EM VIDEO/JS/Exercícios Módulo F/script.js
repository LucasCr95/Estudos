let num = document.querySelector('#txtnum')
let select = document.querySelector('#select')
let res = document.querySelector("#res")
let valores = []

function adicionar(){
    if(numero(num.value) && !notLista(num.value, valores)){
        valores.push(Number(num.value))
        let item = document.createElement('option')
        item.text = `Valor ${num.value} adicionado.`
        select.appendChild(item)
        res.innerHTML = ''
    } else{
        alert('Valor inválido, ou já contém na lista!')
    }
    num.value = ''
    num.focus()
}

function numero(n){
    if(Number(n) >= 1 && Number(n) <= 100){
        return true
    } else{
        return false
    }
}

function notLista(n, lis){
   if( lis.indexOf(Number(n)) != -1){
       return true
   } else{
       return false
   }
}

function analisar(){
    if(valores.length == 0){
        alert('Preencha os campos antes de finalizar')
    } else{
        let total = valores.length
        let maior = valores[0]
        let menor = valores[0]
        let soma = 0
        let media = 0

        for(let pos in valores){
            soma += valores[pos]
            if(valores[pos] > maior)
            maior = valores[pos]
            if(valores[pos] < menor)
            menor = valores[pos]
        }  
         
        media = soma / total
        res.innerHTML = ''
        res.innerHTML += `<p>Ao todo temos ${total} elementos.</p>` 
        res.innerHTML += `<p>O menor valor é ${menor}</p>`
        res.innerHTML += `<p>O maior valor é ${maior}</p>`
        res.innerHTML += `<p>Somando todos os valores, temos ${soma}`
        res.innerHTML += `<p>A média dos valores é: ${media}`
    }
}