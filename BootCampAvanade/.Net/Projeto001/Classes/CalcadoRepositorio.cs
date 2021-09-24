using System;
using System.Collections.Generic;
using Projeto001.Interfaces;

namespace Projeto001
{
	public class CalcadoRepositorio : IRepositorio<Calcado>
	{
        private List<Calcado> listaCalcado = new List<Calcado>();
		
		public void Atualiza(int id, Calcado objeto)
		{
			listaCalcado[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaCalcado[id].Excluir();
		}

		public void Insere(Calcado objeto)
		{
			listaCalcado.Add(objeto);
		}

		public List<Calcado> Lista()
		{
			return listaCalcado;
		}

		public int ProximoId()
		{
			return listaCalcado.Count;
		}

		public Calcado RetornaPorId(int id)
		{
			return listaCalcado[id];
		}
	}
}