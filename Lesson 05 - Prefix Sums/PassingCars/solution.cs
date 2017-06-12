
// Code written in C#
// Correctness: 100 %
// Performance: 100 %
// Time Complexity: O(N)
// Space Complexity: O(1)

using System;

class Solution {
    public int solution(int[] A) {
        
        int w = 0;
        for(int i = 0 ; i < A.Length ; i++)
            w+=A[i]; 
            
        long c = 0;
        for(int i = 0 ; i < A.Length ; i++)
        {
            if(A[i] == 0)
            {
                c += w;
                if(c > 1000000000)
                    return -1;
            }
            else
            {
                w--;
            }
        }        
        
        return (int)c;
    }
}