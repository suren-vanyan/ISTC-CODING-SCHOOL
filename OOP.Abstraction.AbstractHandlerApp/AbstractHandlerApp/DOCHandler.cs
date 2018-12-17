using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandlerApp
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName):base(fileName)
        {

        }
        public override void Change()
        {
            Console.WriteLine($"{_fileName} Change");
        }

        public override void Create()
        {
            Console.WriteLine($"{_fileName} Create");
        }

        public override void Open()
        {
            Console.WriteLine($"{_fileName} Open");
        }

        public override void Save()
        {
            Console.WriteLine($"{_fileName} Save in format DOC");
        }
    }
}
