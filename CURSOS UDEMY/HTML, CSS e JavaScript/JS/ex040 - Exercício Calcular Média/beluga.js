function calcularMedia(n){
    var resultado = n.reduce(function(anterior, atual){
        return anterior + atual
    });
     return resultado /= n.length;
}

function sorteiaNumero(n){
    var num  = Math.floor(Math.random() * (n + 1)); 
    return num;
};
