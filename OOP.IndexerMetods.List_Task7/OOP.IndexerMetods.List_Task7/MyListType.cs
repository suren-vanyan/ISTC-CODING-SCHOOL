using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.IndexerMetods.List_Task7
{
    class MyListType<T> : IMyListType<T>
    {
        private T[] array;
      private  int _length = 0;
        public MyListType()
        {
            array = new T[0];
        }

        public MyListType(int length)
        {
            array = new T[length];
            _length = length;
        }
        public T this[int index]
        {

            set
            {
             
                if (index < 0 || index >= _length)
                    throw new IndexOutOfRangeException();
                 array[index]=value;
            }
  
            get
            {
                if (index < 0 || index >= _length)
                    throw new IndexOutOfRangeException();
                return array[index];
            }
                
        }

        public int Count => array.Length;

        public void Add(T value)
        {
            T[] temporary = new T[++_length];
            for (int i = 0; i < array.Length; i++)
            {
                temporary[i] = array[i];
            }
            temporary[temporary.Length - 1] = value;
            array = temporary;

        }

        public void Swap(int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                    return true;
            }

            return false;
        }

        public void Remove(T index)
        {

            int tempindex = (int)(object)index;
            T[] temporary = new T[_length];
            int currentIndex = 0;      
            for (int i = 0; i < temporary.Length; i++)
            {
                if (i == tempindex)
                    continue;
                temporary[currentIndex++] = array[i];
            }
        }

       
    }
}
