let valor  = [2, 5, 8, 9, 3]

console.log(`O vetor tem ${valor.length} posições`)//       -> Comprimento do vetor(quantidade de índices)

console.log(valor)//            -> Mostrando o vetor 'valor'

let position = valor.indexOf(8)//                               -> Pesquisando onde está o elemento '8'
console.log(`O valor 8 está no índice ${position}`)//           -> Retornando a pesquisa de valor

valor.push(0)//                 -> Adicinando o elemento '0' ao último índice

console.log(valor[2])//         -> Mostrando o elemento que está no indice '2'

valor.sort()//                 -> Ordenando o vetor em ordem crescente