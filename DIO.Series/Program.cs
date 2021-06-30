using System;
using DIO.Series.Serviços;
using DIO.Series.Classes;

namespace DIO.Series
{
    class Program
    {
        static SeriesRepositorio repositorio = new SeriesRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						VisualizarSerie();
						break;
                    case "5":
                        avalia();
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

        private static void VisualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.Retornar(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

            System.Console.Write("Classifique: (1/5)  ");
            int avaliar = int.Parse(Console.ReadLine());

			Serie atualizaSerie = new Serie(id: indiceSerie,
						    	genero: (Genero)entradaGenero,
										nome: entradaTitulo,
										anoLancamento: entradaAno,
										descricao: entradaDescricao,
                                        avaliacao: avaliar);

			repositorio.Atualizar(indiceSerie, atualizaSerie);
		}
        private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");

			var lista = repositorio.listar();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

		}

        private static void InserirSerie()
		{
			Console.WriteLine("Inserir nova série");

			
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

            System.Console.Write("Classifique-a: (1/5) ");
            int avaliar = int.Parse(Console.ReadLine());

			Serie novaSerie = new Serie(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										nome: entradaTitulo,
										anoLancamento: entradaAno,
										descricao: entradaDescricao,
                                        avaliacao: avaliar);

			repositorio.Inserir(novaSerie);
		}

        public static int avalia(){

            System.Console.Write("Informe o Id: ");
            int id = int.Parse(Console.ReadLine());

            if(id == repositorio.ProximoId()){
                 int i = 0;
                int [] nota = new int[i];
                System.Console.Write("Nota (1/5): ");
                nota [i]= int.Parse(Console.ReadLine());
                int notas = 0;
                foreach(int not in nota){
                notas += not;
                }
                i++;
                int  media = notas / nota[i];
                return media;
            
            }else {
             return   0;
            }
            
           
        }

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Bem vindo ao Darwin´s Movie");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Avaliação");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
