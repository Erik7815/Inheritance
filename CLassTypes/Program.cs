using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CLassTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        //VIGA? Kas sealed on õigesti kasutatud
        sealed class Helper
        {
            public void Help()
            {
                Console.WriteLine("Helping...");
            }
        }
        //VIGA? Kas private class töötab siin?
        private class Logger
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
        //VIGA? Kas siin on midagi puudu?
        class SmartWatch : Device
        {
            public void ShowTime()
            {
                Console.WriteLine(name + " shows time");
            }
        }
        //VIGA? Kas protected sobib siia
         class Phone : Device
        {
            public void Call()
            {
                Console.WriteLine(name + " is calling");
            }
        }
        //VIGA? Kas see klass peaks olema private
         class Device
        {
            public string name;

            public void TurnOn()
            {
                Console.WriteLine(name + "is on");
            }
        }
        
    }
}
