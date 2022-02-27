function calcularMedia(){
    var result = 0;
    var x = 0;

    while(x < arguments.length){
        result += arguments[x];
        x++;
    }
    return result /= arguments.length; 
}

function sorteiaNumero(n){
    var num  = Math.floor(Math.random() * (n + 1)); 
    return num;
};
