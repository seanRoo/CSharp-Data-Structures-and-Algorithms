/*
You have been given an array A consisting of N integers. All the elements in this array A are unique. You have to answer some queries based on the elements of this array. Each query will consist of a single integer x. You need to print the rank based position of this element in this array considering that the array is 1 indexed. The rank based position of an element in an array is its position in the array when the array has been sorted in ascending order.

Note: It is guaranteed that all the elements in this array are unique and for each x belonging to a query, value x shall exist in the array

Input Format

The first line consists of a single integer N denoting the size of array A. The next line contains N unique integers, denoting the content of array A. The next line contains a single integer q denoting the number of queries. Each of the next q lines contains a single integer x denoting the element whose rank based position needs to be printed.

Output Format

You need to print q integers denoting the answer to each query.
*/

using System;

class Solution{
    
    public static void Main(string[] args){
        
        Algo al = new Algo();
        int size = Convert.ToInt32(Console.ReadLine());
        int[] numArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int queries = Convert.ToInt32(Console.ReadLine());
        Array.Sort(numArray);
        int lower = 0;
        int upper = numArray.Length-1;
        for(int i=0; i<queries; i++){
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(al.binary(numArray, target));
        }
    }
}
class Algo{
    
    public int binary(int[] arr, int target){
        int lower=0;
        int upper = arr.Length-1;
        while(lower<=upper){
                int median = (upper+lower)/2;
                
                if(target == arr[median]){
                    return median+1;
                }
                else if(target > arr[median]){
                    lower=median+1;
                }
                else{
                    upper = median-1;
                }
            }
            return -1;
        }
    }
