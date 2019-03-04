/*
You have been given an array of size N consisting of integers. In addition you have been given an element M you need to find and print the index of the last occurrence of this element M in the array if it exists in it, otherwise print -1. Consider this array to be 1 indexed.

Input Format:

The first line consists of 2 integers N and M denoting the size of the array and the element to be searched for in the array respectively . The next line contains N space separated integers denoting the elements of of the array.

Output Format

Print a single integer denoting the index of the last occurrence of integer M in the array if it exists, otherwise print -1.
*/

using System;
class Solution{
    
    public static void Main(string[] args){
        Search ls = new Search();
        string[] inputs = Console.ReadLine().Split(' ');
        int numInts = Convert.ToInt32(inputs[0]);
        int target = Convert.ToInt32(inputs[1]);
        
        int[] myArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine(ls.linear(myArray, target));
    
    }
}

class Search{
    bool found = false;
    int index = 0;
    
    public int linear(int[] arr, int target){
        for(int i=0; i<arr.Length; i++){
            if(arr[i] == target){
                found = true;
                index = i;
            }
        }
        
        if(found){
            return index+1;
        }
        else if(!found){
            return -1;
        }
        
        return 0;
    }
}