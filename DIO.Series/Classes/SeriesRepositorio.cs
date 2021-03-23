using DIO.Series.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    public class SeriesRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaserie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            listaserie[id] = entidade;

        }

        public void exclui(int id)
        {
            listaserie[id].remove();

        }

        public void insere(Serie entidade)
        {
            listaserie.Add(entidade);
        }

        public List<Serie> lista()
        {
            return listaserie;
        }

        public int ProximoID()
        {
            return listaserie.Count;

        }

        public Serie RetormaPorId(int id)
        {
            return listaserie[id];
        }
    }
}
