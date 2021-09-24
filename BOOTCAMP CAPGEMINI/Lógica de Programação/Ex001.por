programa
{
	
	funcao inicio()
	{
		real num1, num2, num3, num4, soma, media
		cadeia aluno
		escreva("Nome do aluno: ")
		leia(aluno)
		escreva("Nota da atividade 1: ")
		leia(num1)
		escreva("Nota da atividade 2: ")
		leia(num2)
		escreva("Nota da atividade 3: ")
		leia(num3)
		escreva("Nota da atividade 4: ")
		leia(num4)
		soma = num1 + num2 + num3 + num4
		media = (num1 + num2 + num3 + num4)/4
		escreva("Aluno: " + aluno + ". Soma das notas: " + soma + ". Nota média: " + media)

		se(media >= 7){
			escreva("Parabéns,você foi aprovado!!!")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 558; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */