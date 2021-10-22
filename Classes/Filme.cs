using System;

namespace DIO.Series
{
    public class Filme : EntidadeBase

    {
		private GeneroFilme Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
        private string Diretor { get; set; }
        private string AtoresPrincipais { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}

		public Filme(int id, GeneroFilme genero, string titulo, string descricao, string diretor, 
        string atoresprincipais, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
            this.Diretor = diretor;
            this.AtoresPrincipais = atoresprincipais;
			this.Ano = ano;
            this.Excluido = false;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Diretor: " + this.Diretor + Environment.NewLine;
            retorno += "Atores Principais: " + this.AtoresPrincipais + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo()
		{
			return this.Titulo;
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