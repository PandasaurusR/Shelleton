using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelleton
{
    // Code adapted from http://johnatten.com/2014/09/07/c-building-a-useful-extensible-net-console-application-template-for-development-and-testing/
    /* 
        1. Methods representing Console commands will be defined as public static methods which always return a string, and are defined on public static classes.
    
        2. Classes containing methods representing Console commands will be located in the Commands namespace, and in the Commands folder.
    
        3. There will always be a static class named DefaultCommands from which methods may be invoked from the Console directly by name. For many console project, this will likely be sufficient.
    
        4. Commands defined on classes other than DefaultCommands will be invoked from the console using the familiar dot syntax: ClassName.CommandName.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = typeof(Program).Name;

            Shell.Start();

            Console.WriteLine("Program will terminate...");
            Console.ReadKey();
        }
    }
}
