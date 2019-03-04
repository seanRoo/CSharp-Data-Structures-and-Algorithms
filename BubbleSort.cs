/**You have been given an array A of size N . you need to sort this array non-decreasing oder using bubble sort. However, you do not need to print the sorted array . You just need to print the number of swaps required to sort this array using bubble sort

Input Format

The first line consists of a single integer N denoting size of the array. The next line contains N space separated integers denoting the elements of the array.

Output Format Print the required answer in a single line

**/

using System;

class Solution{
    
    public static void Main(string[] args){
        int size = Convert.ToInt32(Console.ReadLine());
        string[] myArray = Console.ReadLine().Split(' ');
        int[] numArray = new int[size];
        for(int i=0; i< size; i++){
            numArray[i] = int.Parse(myArray[i]);
        }
        CountArr ca = new CountArr();
        Console.WriteLine(ca.count(numArray));
    }
}
class CountArr{
    int temp = 0;
    public int count(int[] arr){
        int count = 0;
        for(int i=0; i<arr.Length-1; i++){
            for(int j=0; j<arr.Length-i-1; j++){
                if(arr[j] > arr[j+1]){
                    swap(arr, j);
                    count ++;
                }
            }
        }
        return count;
    }
    public int[] swap(int[] arr, int index){
        temp = arr[index];
        arr[index] = arr[index+1];
        arr[index+1] = temp;
        
        return arr;
    }
}