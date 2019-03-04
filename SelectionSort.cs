/*
Consider an Array a of size N
Iterate from 1 to N
In ith iteration select the ith minimum and swap it with a[i]
You are given an array a, size of the array N and an integer x. Follow the above algorithm and print the state of the array after x iterations have been performed.

Input Format

The first line contains two integer N and x denoting the size of the array and the steps of the above algorithm to be performed respectively. The next line contains N space separated integers denoting the elements of the array.

Output Format

Print N space separated integers denoting the state of the array after x steps
*/

using System;

class Solution{
    
    public static void Main(String[] args){
        
        string[] input = Console.ReadLine().Split(' ');
        int size = Convert.ToInt32(input[0]);
        int iterations = Convert.ToInt32(input[1]);
        int[] numArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] resultArr = new int[size];
        
        SelectionSort ss = new SelectionSort();
        resultArr = ss.sort(numArray, iterations);
        ss.Print(resultArr);
        
        
    }
}
class SelectionSort{
    int temp = 0;
    
    public int[] sort(int[] arr, int iterations){
        int min = 0;
        for(int i=0; i<iterations; i++){
            min = i;
            for(int j=i+1; j<arr.Length; j++){
                if(arr[j] < arr[min]){
                    min= j ;
                }
            }
            swap(arr, i, min);
                
        }
     return arr;   
    }
    
    public int[] swap(int[] arr, int i, int min){
        int temp = arr[i];
        arr[i] = arr[min];
        arr[min] = temp;
        
        return arr;
        
    }

    public void Print(int[] arr){
        foreach(var item in arr){
            Console.Write(item + " ");
        }
    }
}