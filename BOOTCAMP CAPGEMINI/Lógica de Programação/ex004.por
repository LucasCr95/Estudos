programa
{
	
	funcao inicio()
	{
		inteiro num1, num2, valor, res
		escreva("Digite um número: ")
		leia(num1)
		escreva("Multiplicar até: ")
		leia(valor)		
		num2 = 1
		enquanto(num2 <= valor){
			res = num1 * num2
			escreva("\n" + num1 + " x " + num2 + " = " + res)
			num2 ++ 
		}
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 297; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */