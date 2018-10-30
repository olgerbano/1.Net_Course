using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutieLaborator9
{
    class EnumerableQueue : IEnumerable,ICloneable
    {
        protected object[] queueArraay;
        protected int queueLength;
        protected int maxQueueLength;
       // private object[] temp_queueArraay;

        public EnumerableQueue(EnumerableQueue enumerableQueue) : this(10) { }
        public EnumerableQueue(int size)
        {
            queueArraay = new object[size];
            maxQueueLength = size;
        }
        public virtual void Enqueue(object obj)
        {
          
            if (queueLength >= maxQueueLength)
            {
                this.maxQueueLength = 2 * this.maxQueueLength;
                object [] temp_queueArraay = new object[this.maxQueueLength];
                //for(int i =0;i< queueLength; i++) { temp_queueArraay[i] = queueArraay[i]; }
                queueArraay.CopyTo(temp_queueArraay, 0);
                queueArraay = temp_queueArraay;
            }
            queueArraay[queueLength] = obj;
            queueLength++;
        }

        public virtual object Dequeue
        {
            get
            {
                if (queueLength > 0)
                {
                    object x = queueArraay[0];
                    for (int i = 0; i < queueLength - 1; i++)
                    {
                        queueArraay[i] = queueArraay[i + 1];
                    }
                    queueLength--;
                    return x;
                }
                else
                {
                    throw new InvalidOperationException("Nu sunt elemente in coada!");
                }
            }
        }

        public int get_queueLength()
        {
            return this.queueLength;
        }
        public int get_MAXqueueLength()
        {
            return this.maxQueueLength;
        }
        private class QueueEnumerator : IEnumerator
        {
            private object[] ob;
            private int index = -1;
            private int size;
            public QueueEnumerator(object[] qq, int size)
            {
                ob = qq;
                this.size = size;
            }
            public object Current
            {
                get
                {
                    if (index < 0)
                    {
                        throw new InvalidOperationException("Nu exista elemente in coada");
                    }
                    return ob[index];
                }
            }
            public bool MoveNext()
            {
                index++;
                if (index < size)
                {
                    return true;
                }
                else
                {
                    index = -1;
                    return false;
                }
            }
            public void Reset()
            {
                index = -1;
            }
        }
        public virtual IEnumerator GetEnumerator()
        {
            return new QueueEnumerator(queueArraay, queueLength);
        }

        public object Clone() => new EnumerableQueue(this);
    }
}
