/* Designing my own stack class using generic type parameters */

using System;
using System.Collections;
using System.Collections.Generic;

class Solution{

    static void Main(string[] args){
        
        var al = new ArrayList();
        MyStack<int> stack = new MyStack<int>(3);
        stack.Push_(4);
        stack.Push_(5);
        stack.Push_(6);
        Console.WriteLine(stack.Pop() + " was popped off the Stack!");
        stack.PrintStack();
        stack.Clear();
        stack.PrintStack();

        MyStack<string> strStack = new MyStack<string>(3);
        strStack.Push_("Hello World");
        strStack.Push_("Stack Class Example");
        strStack.Push_("Written in C#!");
        Console.WriteLine(strStack.Pop() + " was popped off the Stack!");
        strStack.PrintStack();
        Console.ReadKey();

    }
}

class MyStack<T>{
    /* Specifying a generic type parameter for the Stack, Stack can be of any type */
    T [] stack;

    /** Private data members to protect from outside modification **/
    private int top;
    private int size;

    /** Initializing Stack with the capacity variable passed to the constructor **/
    public MyStack(int capacity){
        
        size = capacity;
        stack = new T[size];
        top = -1; //Stack is empty
    }
    /* Push to Stack */
    public int Push_(T obj){
        
        if(top == size - 1){ //if stack is full
            return -1; //cant push
        }
        if(obj == null){ //if element is null
            throw new InvalidOperationException(); //throw error
        }
        else{
            Console.WriteLine(obj + " was pushed to the Stack!");
            top+=1; //increment top of Stack
            stack[top] = obj; //insert element at new top
        }
        return 0;
        
    }
    /* Pop off Stack */
    public T Pop(){
        
        T popped; //store popped variable
        T temp = default(T);
        if(!(top <=0)){ //if Stack is not empty
            popped = stack[top];
            top-=1;
            return popped;
        }
        return temp; //return the empty Stack
         
    }
    /* Empty Stack */
    public void Clear(){
        
        Array.Clear(stack,0, stack.Length-1);
        Console.WriteLine("Stack has been emptied!");
    }

    /* Print Stack */
    public void PrintStack(){
        Console.WriteLine("Printing stack contents....");
       for(int i=0; i<=top; i++){
           Console.Write(stack[i] + ", ");
       }
       Console.WriteLine();

   }
}
