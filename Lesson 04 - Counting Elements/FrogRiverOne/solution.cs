// Code written in C#
// Correctness: 100 %
// Performance: 100 %
// Time Complexity: O(N)
// Space Complexity: O(X)

using System;

class Solution {
    public int solution(int X, int[] A) {
        
        int[] a = new int[X+1];        
        
        for(int i = 0 ; i < a.Length ; i++)
            a[i] = -1;
        
        for(int i = A.Length-1; i >=0  ; i--)
        {
            if(A[i] <= X)
            {
               a[A[i]] = i;    
            }                    
        }        
        
        int max = a[0];
        for(int i = 1 ; i < a.Length ; i++)
        {
            if(a[i] == -1)
                return -1;
            
            max = max < a[i] ? a[i] : max;
        }
        
        return max;
    }
}