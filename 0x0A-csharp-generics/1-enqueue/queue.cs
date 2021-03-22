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



