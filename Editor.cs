using System;
using System.Text;

namespace EditorHtml
{
    public class Editor
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("---------------------------------");
            Iniciar();
        }

        public static void Iniciar()
        {
            var arquivo = new StringBuilder();

            do{
                arquivo.Append(Console.ReadLine());
                arquivo.Append(Environment.NewLine);
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("DDeseja salvar o arquivo? Digite S-Sim ou N-Não: ");
            Visualizador.Mostrar(arquivo.ToString());                        
        }

    }
}