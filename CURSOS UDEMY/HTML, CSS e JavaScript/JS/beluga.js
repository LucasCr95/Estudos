function calcularMedia(){
    var result = 0;
    var x = 0;

    while(x < arguments.length){
        result += arguments[x];
        x++;
    }
    result /= arguments.length; 
    
    return result;
}