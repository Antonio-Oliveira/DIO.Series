using DIO.Series.Enums;
using System;

namespace DIO.Series.Classes
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero " + this.Genero + Environment.NewLine;
            retorno += "Titulo " + this.Titulo + Environment.NewLine;
            retorno += "Descrição" + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início" + this.Ano + Environment.NewLine;
            retorno += "Excluido " + this.Excluido;
            return base.ToString();
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

    }
}