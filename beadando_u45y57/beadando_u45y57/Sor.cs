using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_u45y57
{
    internal class Sor<T>:IEnumerable<T>
    {

        LinkedList<T> list = new LinkedList<T>();

       
          public int Length
        {
            get { return list.Count; }

        

        }

        

        public void Add(T elem)
        {
            list.AddFirst(elem);
           
        }

      
       

        public T Pop()
        {
           T kovetkezo= list.Last<T>();
            list.AddFirst(kovetkezo);
            list.RemoveLast();
            
            return kovetkezo;
        }

        public T Peek()
        {
            return list.Last.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)list).GetEnumerator();
        }
    }
}