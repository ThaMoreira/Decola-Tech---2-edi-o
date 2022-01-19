using System;

namespace Dio.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        public static void Main(string[] args){
            string opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario.ToUpper != "x"){
                switch (opcaoUsuario)
                {
                    case "1":
                    ListarSerie();
                    break;
                    case "2":
                    InserirSerie();
                    break;
                    case "3":
                    AtualizarSerie();
                    break;
                    case "4":
                    ExcluirSerie();
                    break;
                    case "5":
                    VisualizarSerie();
                    break;
                    case "c":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
            }

        }

        private static void ListarSerie(){
            Console.WriteLine("Listar");
            var lista = repositorio.Lista();
            if(lista.Count ==0)
            {
                Console.WriteLine("Nenhuma série");
                return;
            }
            foreach(var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo);
            }
        }

        private static void InserirSerie(){
            Console.WriteLine("Inserir serie");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}: - {1}", i, Enum.GetName(typeof(Genero)));
            
            }
            Console.WriteLine("Digite o genero");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o titulo");
            string entradaTitulo = Console.ReadLine();
            Console.WriteLine("Digite o Ano");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o genero");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            ano: entradaAno,
            descricao: entradaDescricao);

            repositorio.Insere(novaSerie);
        }

        private static void AtualizarSerie(){
            Console.WriteLine("Digite o ID");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}: - {1}", i, Enum.GetName(typeof(Genero), i));
            
            }
            Console.WriteLine("Digite o genero");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o titulo");
            string entradaTitulo = Console.ReadLine();
            Console.WriteLine("Digite o Ano");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o genero");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
            genero: (Genero)entradaGenero,
            titulo: entradaTitulo,
            ano: entradaAno,
            descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
        private static void ExcluirSerie(){
            Console.Write("Digite o id");
           int indiceSerie = int.Parse(Console.ReadLine());
           repositorio.Exclui(indiceSerie);

        }
         private static void VisuzalizarSerie(){
            Console.Write("Digite o id");
           int indiceSerie = int.Parse(Console.ReadLine());
           var serie = repositorio.RetornaPorId(indiceSerie);
           Console.WriteLine(serie);

        }


        private static string ObterOpcaoUsuario(){
                Console.WriteLine();
                Console.WriteLine("Dio séries");
                Console.WriteLine("Informe a opção");
                Console.WriteLine("1- listar séries");
                Console.WriteLine("2 - inserir nova série");
                Console.WriteLine("3 - Atualizar série");
                Console.WriteLine("4 - Exluir série");
                Console.WriteLine("5 - Visualizar série");
                Console.WriteLine("c - Limpar tela");
                Console.WriteLine("x - sair");
                Console.WriteLine();

                string opcaoUsuario = Console.WriteLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
        }

    }
            
        

 }


