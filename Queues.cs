/*
Micro just purchased a queue and wants to perform N operations on the queue. The operations are of following type:

Ex : Enqueue x in the queue and print the new size of the queue.
D : Dequeue from the queue and print the element that is deleted and the new size of the queue separated by space. If there is no element in the queue then print 1 in place of deleted element.

Since Micro is new with queue data structure, he need your help.

Input:
First line consists of a single integer denoting N
Each of the following N lines contain one of the operation as described above.

Output:
For each enqueue operation print the new size of the queue. And for each dequeue operation print two integers, deleted element (1, if queue is empty) and the new size of the queue.
*/
using System;
using System.Collections.Generic;
using System.Collections;

class Solution{
    
    public static void Main(String[] args){
        Queue q = new Queue();
        Q obj = new Q(q);
        string input = "";
        int operations = int.Parse(Console.ReadLine());
        
        for(int i=0; i<operations; i++){
            input = Console.ReadLine();
            if(input[0].Equals('D')){
                obj.dQ();
            }
            else{
                obj.enQ(Convert.ToInt32(input.Substring(2)));
                
            }
        }

    }
}
class Q{
    
    Queue q;
    
    public Q(Queue q){
        this.q = q;
    }
    public void enQ(int num){
        q.Enqueue(num);
        Console.WriteLine(q.Count);
    }
    public void dQ(){
        int temp=0;
        if(q.Count > 0){
            temp = (int)q.Dequeue();
            Console.WriteLine(temp + " " + q.Count);
        }
        else{
            Console.WriteLine(-1 + " " + q.Count);
        }
    }
}