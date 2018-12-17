using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHandlerApp
{
    abstract class AbstractHandler
    {
        protected string _fileName;

        public AbstractHandler(string fileName = "NoName")
        {
            _fileName = fileName;
        }
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();

    }
}
