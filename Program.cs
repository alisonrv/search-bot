// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using EasyAutomationFramework;
using OpenQA.Selenium;
using System.Security.AccessControl;

namespace MeuBot{
    
    internal class Program
    {
        static void Main(string[] main)
        {
            string requesicao;
            Console.WriteLine("Qual sua pesquisa?");
            requesicao= Console.ReadLine();
            var web = new Web();
            web.StartBrowser();
            web.Navigate("https://www.wikipedia.org/");
            web.AssignValue(TypeElement.Id, "searchInput", requesicao).element.SendKeys(Keys.Enter);
        }
    }
}