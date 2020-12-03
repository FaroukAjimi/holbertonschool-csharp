using System;

using System.Collections.Generic;
    class MyQueue
    {
        public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
        {
             int c = 0;
            bool chk = false;
            string top = "";
            int c2 = 0;
            bool srch = false;
            int index = 0;
            foreach(var i in aQueue)
            {
                if(chk is false)
                {
                    top = i;
                    chk = true;
                }
                if(i == search)
                {
                    srch = true;
                    index = c;
                }
                c += 1;
            }
            if (srch == true)
                while(c2 <= index)
                {
                    aQueue.Dequeue();
                    c2++;
                }
            aQueue.Enqueue(newItem);
            Console.WriteLine("Number of items: {0}", c);
            if (c > 0)
                Console.WriteLine("Top item: {0}", top);
            else
                Console.WriteLine("Queue is empty");
            Console.WriteLine("Queue contains \"{0}\": {1}", search, srch);
            return(aQueue);
        }
    }
