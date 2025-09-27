using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Practise
{
    internal class SimpleList<T>
    {
        private int _count;
        private T[] _array;

        public SimpleList()
        {
            _count = 0; 
            _array = new T[4];
        }

        public T this[int index]
        {
            get
            {
                Console.WriteLine("GET!");
                return _array[index];
            }
            set
            {
                Console.WriteLine("SET!");
                _array[index] = value;
            }
        }
        

        public int Count()
        {
            return _count;
        }

        public void Add(T value)
        {
            if(_count == _array.Length)
            {
                Resize();
            }
            _array[_count] = value;
            _count++;
        }
        
        public T Get(int index)
        {
            if(index >= _count)
            {
                throw new ArgumentOutOfRangeException();
            }


            return _array[index];
        }

        public void RemoveBy(int index)
        {
            for(int i = index; i < _count-1; i++)
            {
                _array[i] = _array[i + 1];
            }
                _count --;
        }
        
        private void Resize()
        {
            T[] newArray = new T[_count * 2];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;

        }

        public void RemoveLast()
        {
            _count--;
        }
    }
}
