function verificar(){
    let valorI = Number(document.querySelector('#valori').value)
    let valorF = Number(document.querySelector('#valorf').value)
    let valorP = Number(document.querySelector('#valorp').value)
    let res = document.querySelector('#res')
    
    if(valorI === 0 || valorF === 0 || valorP === 0){
        res.innerHTML = `Preencha os campos com dados válidos.`
    } else if(valorI <= valorF){
        for (let calc = valorI; calc <= valorF; calc += valorP){
          res.innerHTML += ` ${calc} \u{1F449} `  
        }
    } else{
        for(let calc = valorI; calc >= valorF; calc -= valorP){
        res.innerHTML += ` ${calc} \u{1F449}`
        }
        res.innerHTML += `<p>Fim da contagem!</p>`
        }
    }