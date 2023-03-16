using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            DesenharTela();
            Opcoes();

            var opcao = short.Parse(Console.ReadLine());
            ManipularMenuOpcao(opcao);
        }

        public static void DesenharTela()
        {
            Colunas();

            Linhas();

            Colunas();
        }

        public static void Colunas()
        {
            Console.Write("+");
            for(int i = 0; i<=30; i++)
                Console.Write("-");
            
            Console.Write("+");
            Console.Write("\n");
        }

        public static void Linhas()
        {
            for(int linhas = 0; linhas <= 10; linhas++)
            {
                Console.Write("|");
                for(int i = 0; i <= 30; i++)
                    Console.Write(" ");
                
                Console.Write("|");
                Console.Write("\n");
            } 
        }

        public static void Opcoes()
        {
            // controla aonde o cursor da tela aparecerá
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("3 - Sair");
            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
        }

        public static void ManipularMenuOpcao(short option)
        {
            switch(option)
            {
                case 1: Editor.Mostrar(); break;
                case 2: Console.WriteLine("View"); break;
                case 0: 
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Mostrar(); break;
            }
        }

    }
}