using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.IndexerMetods.List_Task7
{
    interface IMyListType<T>
    {
        void Add(T value);
        T this[int index] { get;set; }
        int Count { get; }
        void Clear();
        void Remove(T index);
        bool Contains(T item);

    }
}
