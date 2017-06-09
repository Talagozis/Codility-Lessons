// Code written in C#
// Correctness: 100 %
// Performance: 100 %
// Time Complexity: O(N)
// Space Complexity: O(N)

using System;

class Solution {
    public int solution(int[] A) {
        
        long s = 0;
        int c1 = 0;
        int c2 = 0;
        
        for(int i = 0 ; i < A.Length ; i++)
        {
            s += A[i] - (i + 1);
            c1 = c1 ^ A[i];
            c2 = c2 ^ (i + 1);
        }            
        
        return s == 0 && c1 == c2 ? 1 : 0;
    }
}