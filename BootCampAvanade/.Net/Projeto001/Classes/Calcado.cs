using System;

namespace Projeto001
{
    public class Calcado : EntidadeBase
    {
        // Atributos
		private Marca Marca { get; set; }
		private string Modelo { get; set; }
		private string Descricao { get; set; }
		private int Tamanho { get; set; }
        private bool Excluido {get; set;}

        // Métodos
		public Calcado(int id, Marca marca, string modelo, string descricao, int tamanho)
		{
			this.Id = id;
			this.Marca = marca;
			this.Modelo = modelo;
			this.Descricao = descricao;
			this.Tamanho = tamanho;
            this.Excluido = false;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Marca: " + this.Marca + Environment.NewLine;
            retorno += "Modelo: " + this.Modelo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Tamanho: " + this.Tamanho + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaModelo()
		{
			return this.Modelo;
		}

		public int retornaId()
		{
			return this.Id;
		}

        public bool retornaExcluido()
		{
			return this.Excluido;
		}

        public void Excluir() {
            this.Excluido = true;
        }
    }
}