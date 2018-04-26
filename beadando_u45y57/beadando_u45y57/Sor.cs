using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_u45y57
{
    public class Sor<T> : ICollection<T>
    {
        public int Length
        {
            get { return this.Count; }
        }

        internal SorNode<T> Head
        {
            get;
            private set;
        }

        internal SorNode<T> Tail
        {
            get;
            private set;
        }

        #region Add

        public void AddFirst(T value)
        {
            AddFirst(new SorNode<T>(value));
        }

        internal void AddFirst(SorNode<T> node)
        {
            SorNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if (Count == 1)
            {
                Tail = Head;
            }
        }

        //public void AddLast(T value)
        //{
        //    AddLast(new SorNode<T>(value));
        //}

        //public void AddLast(SorNode<T> node)
        //{
        //    if (Count == 0)
        //    {
        //        Head = node;
        //    }
        //    else
        //    {
        //        Tail.Next = node;
        //    }
        //    Tail = node;
        //    Count++;
        //}

        #endregion Add

        #region Remove

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Tail = null;
                    Head = null;
                }
                else
                {
                    SorNode<T> current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    Tail = current;
                    Tail.Next = null;
                }
                Count--;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        #endregion Remove

        #region ICollection

        public int Count
        {
            get;
            private set;
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public bool Contains(T item)
        {
            SorNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            SorNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex] = current.Value;
                current = current.Next;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool Remove(T item)
        {
            SorNode<T> previous = null;
            SorNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            SorNode<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        #endregion ICollection

        #region beadandohoz_szukseges_kiegeszitesek

        public T Pop()
        {
            T kovetkezo = this.Last<T>();
            this.AddFirst(kovetkezo);
            this.RemoveLast();

            return kovetkezo;
        }

        public T Peek()
        {
            return this.Last<T>();
        }

        #endregion beadandohoz_szukseges_kiegeszitesek
    }
}