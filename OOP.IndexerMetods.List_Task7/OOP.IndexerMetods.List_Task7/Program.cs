using System;
using System.Collections.Generic;

namespace OOP.IndexerMetods.List_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            MyListType<int> myListOne = new MyListType<int>(2);

            myListOne[0] = 10;
            myListOne[1] = 20;
            myListOne.Add(10);
            myListOne.Add(20);
            myListOne.Add(30);
            myListOne.Remove(2);

           
        }
    }
}
