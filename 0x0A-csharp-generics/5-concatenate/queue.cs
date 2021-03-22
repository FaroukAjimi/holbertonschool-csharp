using System;
///<summary> generic class Queue </summary>
class Queue<T>
{
    Node head {get; set;}
    Node tail {get; set;}
    int count {get; set;}

    ///<summary> class method </summary>
    public Type CheckType()
    {
        return(typeof(T));
    }
    ///<summary> enqueue </summary>
    public void Enqueue(T val) {
        if (head == null)
        {
            Node newHead = new Node(val);
            head = tail = newHead;
        }
        else{
            Node NewTail = new Node(val);
            tail.next = NewTail;
            tail = NewTail;
        }
        count++;
    }
    ///<summary> dequeue </summary>
    public T Dequeue()
    {
        if (null != head)
        {
            Node rm = new Node(default(T));
            rm = head;
            head = head.next;
            count--;
            return rm.value;
        }
        Console.WriteLine("Queue is empty");
        return(default(T));
    }
    public T Peek()
    {
        if (head != null)
            return(head.value);
        else
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
    }
    public void Print()
    {
        if (head == null)
        Console.WriteLine("Queue is empty");
        while(head != null)
        {
            Console.WriteLine(head.value);
            head = head.next;
        }
    }
    public String Concatenate(){
        
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(null);
        }
        if (typeof(String) == typeof(T) || typeof(Char) == typeof(T))
        {
            String s = "";
            while(head != null)
            {
                s = s + head.value;
                if (typeof(String) == typeof(T))
                s = s + " ";
                head = head.next;
            }
            return(s);
        }
        Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
        return(null);

    }
    ///<summary> count </summary>
    public int Count(){
        return count;
        }
///<summary> summary class </summary>
public class Node{
    public T value {get; set;}
    public Node next {get; set;}
    
    ///<summary> const </summary>
    public Node(T value)
         {
             this.value = value;
         }
} 
}



