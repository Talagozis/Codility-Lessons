// Code written in C#
// Correctness: 100 %
// Performance: 100 %
// Time Complexity: O(N + M) 
// Space Complexity: O(N)

using System;

class Solution {
    public int[] solution(int N, int[] A) {
        
        int length = A.Length;
        
        int[] a = new int[N];
        for(int i = 0 ; i < N ; i++)
            a[i] = 0;           
        
        int max = 0;
        int maxt = 0;
        for(int i = 0 ; i < length ; i++)
        {
            if(A[i] >= 1 && A[i] <= N)
            {   
                if(maxt <= a[A[i]-1])
                {
                    a[A[i]-1]++;
                }
                else
                {
                    a[A[i]-1] = maxt + 1;
                }                
                
                max = max < a[A[i]-1] ? a[A[i]-1] : max;
            }
            else if(A[i] == N+1)
            {
                maxt = max;
            }
        }
         
        for(int i = 0 ; i < N ; i++)
        {
            if(maxt > a[i])
            {
                a[i] = maxt;
            }   
        }
         
        return a;
    }
}