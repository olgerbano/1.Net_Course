using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace SolutieLaborator9
{

    public class Program
    {
        public static void Main()
        {
            EnumerableQueue itemEnum = new EnumerableQueue(2);
            itemEnum.Enqueue(1);
            itemEnum.Enqueue(2.2);
            itemEnum.Enqueue(3);
            itemEnum.Enqueue("hello");
            itemEnum.Enqueue(10);
            itemEnum.Enqueue(20);
            itemEnum.Enqueue(30);
            itemEnum.Enqueue("heeello");

            foreach (object item in itemEnum)
            {
                Console.Write(item + " ");
            }
           Console.WriteLine();

            for (IEnumerator ie = itemEnum.GetEnumerator(); ie.MoveNext(); )
            {
                Console.Write(ie.Current + " ");
            }
            
            Console.ReadKey();
            object itemi;
            itemi = itemEnum.Dequeue;
            itemi = itemEnum.Dequeue;
            itemi = itemEnum.Dequeue;
            itemi = itemEnum.Dequeue;

            Console.WriteLine();

            for (IEnumerator ie = itemEnum.GetEnumerator(); ie.MoveNext();)
            {
                Console.Write(ie.Current + " ");
            }
            Console.ReadKey();
        }
    }
}
