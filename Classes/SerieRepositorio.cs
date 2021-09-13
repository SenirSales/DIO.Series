using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepsitorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}
		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}
		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}
		public List<Serie> Lista()
		{
			return listaSerie;
		}
		public int ProximoId()
		{
			return listaSerie.Count;
		}
		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
        public bool Verifica_Id(int id)
        {
            bool retorno = false;
            if (listaSerie.Count == 0)
            {
                Console.WriteLine("Nao existe dados cadastrados!!!");
            }
            else if (listaSerie.Exists(item => item.Id != id))
            {
                Console.WriteLine("Nao existe item cadastrado!!!");
            }
            else
            {
                var item = listaSerie.Find(item => item.Id == id);
                
                if(item.retornaExcluido())
                {
                    Console.WriteLine("Item Excluido!!!");
                }
                else
                {
                    retorno = true;
                }
            }
            //retorno = false;
            return retorno;
        }
    }
}