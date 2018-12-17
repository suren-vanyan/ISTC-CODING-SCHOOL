using System;

namespace AbstractHandlerApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Redactor redactor = new Redactor();
            redactor.DocumentReadctor("myDocument.doc");
            AbstractHandler handler = redactor.Handler;

            // it's a bad style ;
            handler.Open();
            handler.Change();
            handler.Create();
            handler.Save();

            //good style
            if(handler is DOCHandler e)
            {
                e.Open();
                e.Change();
                e.Create();
                e.Save();
            }
        }
    }
}
