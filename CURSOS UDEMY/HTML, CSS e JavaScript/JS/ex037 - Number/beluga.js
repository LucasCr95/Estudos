function calcularMedia(){
    var result = 0;
    var x = 0;

    while(x < arguments.length){
        result += arguments[x];
        x++;
    }
    result /= arguments.length; 
    
    return result.toFixed(2);
};

function sorteiaNumero(n){
    if(n === 2){
        var num = Math.random() * 2;
        num = Math.floor(num);
    }else if(n === 10){
        var num = Math.random() * 10;
        num = Math.floor(num);
    }
    console.log(num);
};