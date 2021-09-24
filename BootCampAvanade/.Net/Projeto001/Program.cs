using System;

namespace Projeto001
{
    class Program
    {
        static CalcadoRepositorio repositorio = new CalcadoRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarCalcados();
						break;
					case "2":
						InserirCalcado();
						break;
					case "3":
						AtualizarCalcado();
						break;
					case "4":
						ExcluirCalcado();
						break;
					case "5":
						VisualizarCalcado();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

		private static void ExcluirCalcado()
		{
			Console.Write("Digite a referência do produto: ");
			int indiceCalcado = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceCalcado);
		}

		private static void VisualizarCalcado()
		{
			Console.Write("Digite a referência: ");
			int indiceCalcado = int.Parse(Console.ReadLine());

			var calcado = repositorio.RetornaPorId(indiceCalcado);

			Console.WriteLine(calcado);
		}

		private static void AtualizarCalcado()
		{
			Console.Write("Digite a referência do produto: ");
			int indiceCalcado = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Marca)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Marca), i));
			}
			Console.Write("Digite a marca dentre as opções acima: ");
			int entradaMarca = int.Parse(Console.ReadLine());

			Console.Write("Digite o modelo: ");
			string entradaModelo = Console.ReadLine();

			Console.Write("Digite o tamanho: ");
			int entradaTamanho = int.Parse(Console.ReadLine());

			Console.Write("Digite a descrição: ");
			string entradaDescricao = Console.ReadLine();

			Calcado AtualizaCalcado = new Calcado(id: indiceCalcado,
										marca: (Marca)entradaMarca,
										modelo: entradaModelo,
										tamanho: entradaTamanho,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceCalcado, AtualizaCalcado);
		}

        private static void ListarCalcados()
		{
			Console.WriteLine("Listar opções");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Estoque vazio.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#REF {0}: - {1} {2}", serie.retornaId(), serie.retornaModelo(), (excluido ? "[ESGOTADO]" : ""));
			}
		}

        private static void InserirCalcado()
		{
			Console.WriteLine("Inserir novo produto");

			foreach (int i in Enum.GetValues(typeof(Marca)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Marca), i));
			}

			Console.Write("Digite a marca dentre as opções acima: ");
			int entradaMarca = int.Parse(Console.ReadLine());

			Console.Write("Digite o modelo: ");
			string entradaModelo = Console.ReadLine();

			Console.Write("Digite o tamanho: ");
			int entradaTamanho = int.Parse(Console.ReadLine());

			Console.Write("Digite a descrição: ");
			string entradaDescricao = Console.ReadLine();

			Calcado novoCalcado = new Calcado(id: repositorio.ProximoId(),
										marca: (Marca)entradaMarca,
										modelo: entradaModelo,
										tamanho: entradaTamanho,
										descricao: entradaDescricao);

			repositorio.Insere(novoCalcado);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("JL Calçados!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Mostrar modelos");
			Console.WriteLine("2- Inserir novo produto");
			Console.WriteLine("3- Atualizar produto");
			Console.WriteLine("4- Excluir produto");
			Console.WriteLine("5- Visualizar descrições");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
