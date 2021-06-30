namespace DIO.Series.Classes
{

    public abstract class dados
    {
        public int id {get; protected set;}
        public string nome {get; protected set;}
        public string descricao {get; protected set;}
        public int anoLancamento {get; protected set;}
        public int avaliacao {get; protected set;}

    }
}