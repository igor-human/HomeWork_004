using System;
using Task_02;

namespace Abstraction
{
    class Program
    {
        static void Main()
        {
            AbstractHandler handler = new XMLHandler();
            string docType = "doc";

            switch (docType)
            {
                case "xml":
                    handler = new XMLHandler();
                    break;
                case "txt":
                    handler = new TXTHandler();
                    break;
                case "doc":
                    handler = new DOCHandler();
                    break;
                default:
                    Console.WriteLine("Error");
                    return;
            }
                
                

            handler.Create();
            handler.Change();
            handler.Save();
            handler.Open();

            //Delay.
            Console.ReadKey();
        }
    }
}
