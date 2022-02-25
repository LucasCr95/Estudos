function calcularMedia(){
    var result = 0;
    var x = 0;

    while(x < arguments.length){
        result += arguments[x];
        x++;
    }
    result /= arguments.length; 
    
    return result.toFixed(2); 
}

function sorteiaNumero(n){
    var num  = Math.floor(Math.random() * (n + 1)); 
    return num;
};