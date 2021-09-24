programa
{
	
	funcao inicio()
	{
		real vendaMarco, vendaAbril, vendaMaio, vendaJunho, vendaMedia
		cadeia vendedor

		escreva ("Digite o nome do vendedor: ")
		leia (vendedor)
		escreva ("Vendas de Março: ")
		leia (vendaMarco)
		escreva ("Vendas de Abril: ")
		leia (vendaAbril)
		escreva ("Vendas de Maio: ")
		leia(vendaMaio)
		escreva ("Vendas de Junho: ")
		leia(vendaJunho)
		vendaMedia = (vendaAbril + vendaMaio + vendaMaio + vendaJunho)/4

		escreva ("Vendedor: " + vendedor + ". Venda Média: " + vendaMedia)
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 158; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */