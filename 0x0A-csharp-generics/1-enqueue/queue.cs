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
    public int Count(){
        return count;
        }
public class Node{
    public T value {get; set;} = default;
    public Node next {get; set;} = default;
    
    public Node(T value)
         {
             this.value = value;
         }
} 
}



