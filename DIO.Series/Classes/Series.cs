using System;
using DIO.Series.Serviços;

namespace DIO.Series.Classes
{
    public class Serie : dados
    {

        private Genero genero {get; set;}
        public Serie(int id, string nome, Genero genero, string descricao, int anoLancamento, int avaliacao) {
            this.id = id;
            this.nome = nome;
            this.genero = genero;
            this.descricao = descricao;
            this.anoLancamento = anoLancamento;
            this.avaliacao = avaliacao;
        }

        public Serie(){
        }

        public override string ToString(){
            string retorno = "";
            retorno += "Gênero: " + this.genero + Environment.NewLine;
            retorno += "Título: " + this.nome + Environment.NewLine;
            retorno += "Descrição: " + this.descricao + Environment.NewLine;
            retorno += "Ano de lançamento: " + this.anoLancamento + Environment.NewLine;
            retorno += "Avaliação: " + this.avaliacao + Environment.NewLine;
            return retorno;
        }

        public string RetornarTitulo(){
            return this.nome;
        }

        public int RetornarId(){
            return this.id;
        }
    }
}