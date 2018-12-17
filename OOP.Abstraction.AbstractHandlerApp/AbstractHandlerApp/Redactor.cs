using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandlerApp
{
    class Redactor
    {
        private AbstractHandler _handler = null;
        internal AbstractHandler Handler { get => _handler; set => _handler = value; }

        public void DocumentReadctor(string file)
        {
            if (file == null)
            {
                Console.WriteLine("You have not uploaded the file");
                return;
            }

            string fileFormat = file.Substring(file.Length - 3);
            switch (fileFormat)
            {
                case "txt": _handler = new TXTHandler(file); break;
                case "doc": _handler = new DOCHandler(file); break;
                case "xml": _handler = new XMLHandler(file); break;
                default:
                    Console.WriteLine("Format not recognized");
                    break;
            }
        }
    }
}
