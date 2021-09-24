programa
{
	
	funcao inicio()
	{
		escreva("1-Netflix; 2-Amazon; 3-HBO; 4-Disney+")
		inteiro valor = 0

		escreva("\n" + "Escolha um player: ")
		leia(valor)
		
		escolha(valor)
		{
			caso 1: {
			escreva("Abrindo Netflix...")
			pare
			}	
			caso 2: {
			escreva("Abrindo Amazon-Prime...")
			pare
			}
			caso 3: {
				escreva("Abrindo HBO-Max...")
				pare
			}
			caso 4: {
				escreva("Abrindo Disney-Plus")
				pare
			}
			caso contrario: {
				escreva("\n" + "Digite uma opção válida.")
			}
		} 
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 140; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */