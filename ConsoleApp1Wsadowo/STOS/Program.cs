using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOS
{
    class Program
    {
        static void Main(string[] args)
        {
            public class Stos<T> : IStos<T> {


            private List<T> lista;
            private T top;

            public Stos()
            {
                lista = new List<T>();
            }

            public T Peek
            {
                get
                {
                    if (IsEmpty) throw new StosEmptyException();
                    return top;
                }
            }

            public int Count => lista.Count;

            public bool IsEmpty => Count == 0;

            public void Clear()
            {
                lista.Clear();
            }

            public T Pop()
            {
                if (IsEmpty) throw new StosEmptyException();

                T elem = lista[Count - 1];
                lista.RemoveAt(Count - 1);
                if (Count > 0) top = lista[Count - 1];

                return elem;
            }

            public void Push(T value)
            {
                lista.Add(value);
                top = value;
            }

            public T[] ToArray()
            {
                return lista.ToArray();
            }
        
        }
    }
}
