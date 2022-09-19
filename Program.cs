// See https://aka.ms/new-console-template for more information
//development by alison ribeiro
using EasyAutomationFramework;
using OpenQA.Selenium;
using System.Security.AccessControl;

namespace MeuBot
{

    internal class Program
    {
        static void Main()
        {
            string pesquisaUsuario; char alternativaInicial;
            Console.Clear();
            Console.WriteLine("Em qual plataforma deseja buscar?\n[A] Google\n[B] Wikipedia\n[C] YouTube\n[D] StackOverflow");
            System.Console.WriteLine("=======================");
            alternativaInicial = char.Parse(Console.ReadLine());
            if (alternativaInicial == 'a' || alternativaInicial == 'A')
            {
                Console.Clear();
                System.Console.WriteLine("[OPÇÃO SELECIONADA - Google]");
                Console.WriteLine("Perfeito! Digite abaixo sua pesquisa: ");
                pesquisaUsuario = Console.ReadLine();
                var web = new Web();
                web.StartBrowser();
                web.Navigate("https://www.google.com/");
                web.AssignValue(TypeElement.Name, "q", pesquisaUsuario).element.SendKeys(Keys.Enter);
            }
            else if (alternativaInicial == 'b' || alternativaInicial == 'B')
            {
                Console.Clear();
                System.Console.WriteLine("[OPÇÃO SELECIONADA - Wikipedia]");
                Console.WriteLine("Perfeito! Digite abaixo sua pesquisa: ");
                pesquisaUsuario = Console.ReadLine();
                var web = new Web();
                web.StartBrowser();
                web.Navigate("https://www.wikipedia.org/");
                web.AssignValue(TypeElement.Id, "searchInput", pesquisaUsuario).element.SendKeys(Keys.Enter);
            }
            else if (alternativaInicial == 'c' || alternativaInicial == 'C')
            {
                Console.Clear();
                System.Console.WriteLine("[OPÇÃO SELECIONADA - YouTube]");
                Console.WriteLine("Perfeito! Digite abaixo sua pesquisa: ");
                pesquisaUsuario = Console.ReadLine();
                var web = new Web();
                web.StartBrowser();
                web.Navigate("https://www.youtube.com/");
                web.AssignValue(TypeElement.Name, "search_query", pesquisaUsuario).element.SendKeys(Keys.Enter);
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("[OPÇÃO SELECIONADA - StackOverflow]");
                Console.WriteLine("Perfeito! Digite abaixo sua pesquisa: ");
                pesquisaUsuario = Console.ReadLine();
                var web = new Web();
                web.StartBrowser();
                web.Navigate("https://stackoverflow.com/");
                web.AssignValue(TypeElement.Name, "q", pesquisaUsuario).element.SendKeys(Keys.Enter);
            }
        }
    }
}