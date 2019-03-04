/*You have been given an A array consisting of N integers. All the elements in this array are guaranteed to be unique. For each position i in the array A you need to find the position A[i] should be present in, if the array was a sorted array. You need to find this for each i and print the resulting solution.

Input Format:

The first line contains a single integer N denoting the size of array A. The next line contains N space separated integers denoting the elements of array A.

Output Format:

Print N space separated integers on a single line , where the Ith integer denotes the position of A[i] if this array were sorted.*/

using System;

class Solution{
    
    static void Main(String[] args){
        
        int size = int.Parse(Console.ReadLine());
        int[] originalArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] sortedArray = new int[size];
        int[] notSortedArray = new int[size];
        
        for(int i=0; i<size; i++){
            sortedArray[i] = originalArray[i];
            notSortedArray[i] = originalArray[i];
        }
        
        Insertion insertSort = new Insertion();
        Locate solution = new Locate();
        sortedArray= insertSort.sort(sortedArray);
        
        solution.solve(sortedArray, notSortedArray, size);
        
    }
}

class Locate{
    
    public void solve(int[] sorted, int[] notSorted, int size){
        for(int i=0; i<size; i++){
            int thisNum = notSorted[i];
            Console.Write(Array.IndexOf(sorted, notSorted[i]) + 1 + " ");
        }
    }
}

class Insertion{
    int temp = 0;
    public int[] sort(int[] arr){
        
        for(int i=0; i< arr.Length; i++){
            int j=i;
            
            while(j>0){
                if(arr[j] < arr[j-1]){
                    arr = swap(arr, j-1, j);
                }
                j--;
            }
        }
        return arr;
    }
    public int[] swap(int[] arr, int left, int right){
        temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
        
        return arr;
        
    }
    public void print(int[] arr){
        foreach(var item in arr){
            Console.Write(item + " ");
        }
    }
}