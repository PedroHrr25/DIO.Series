

using System;

namespace DIO.Series
{
    class Series : EntidadeBase 
    {
        // atributos
        private Genero Genero   { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        
        private bool Excluido { get; set; }


        //Metodos
        public Series(int id,Genero genero, string titulo, string descricao, int ano)
        {
            ID = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero:" + Genero + Environment.NewLine;
            retorno += "Titulo:" + Titulo + Environment.NewLine;
            retorno += "Descricao:" + Descricao + Environment.NewLine;
            retorno += "Ano de inicio:" + Ano;


            return retorno;
        }


        public string retornaTitulo()
        {
            return Titulo;

        }

        public int retornaId()
        {
            return ID;
        }

        public void exclui()
        {
            Excluido = true;
        }

    }
}
