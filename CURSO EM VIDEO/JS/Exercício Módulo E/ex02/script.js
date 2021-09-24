function gerar() {
    let valorBase = Number(document.querySelector('#primeiro-valor').value)
    let valorMultiplica = Number(document.querySelector('#segundo-valor').value)
    res = document.querySelector('#res')

    if(valorBase === 0 || valorMultiplica === 0){
        alert('[ERRO] Confira os dados e tente novamente.')
        
    } else {
        res.innerHTML = ''
        for (let n = 1; n <= valorMultiplica ; n++){
            let item = document.createElement('option')
            //Criando o elemento 'option' dentro do 'select'
            
            let valorFinal = valorBase * n
            item.innerHTML += `${valorBase} x ${n} = ${valorFinal}`
            res.appendChild(item)// Aplicando o elemento filho 'option'
        }
    }
}