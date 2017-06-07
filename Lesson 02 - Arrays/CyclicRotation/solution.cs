// Code written in C#
// Correctness: 100 %
// Performance: Not assessed
// Time Complexity: O(N)
// Space Complexity: O(N)

using System;

class Solution {
    public int[] solution(int[] A, int K) {
        
        int length = A.Length;

        if(length == 0 || K == 0)
            return A;

        if(0 == K % length)
            return A;

        int[] r = new int[length];

        for(int i=0; i<length;i++)
        {
            r[(i + K) % length] = A[i];   
        }

        return r;
    }
}