#Code written in C#
#Correctness: 100 %
#Performance: 100 %
#Time Complexity: O(N)
#Space Complexity: O(1)

using System;

class Solution {
    public int solution(int[] A) {
        long l = A[0];
        long r = -A[0];
        foreach(int i in A)
            r += i;
        
        long min = Math.Abs(l - r);
        
        for(int i = 1 ; i < A.Length - 1; i++ )
        {
            l += A[i];
            r -= A[i];
            min = min < Math.Abs(l - r) ? min : Math.Abs(l - r);
        }
        
        return (int)min;
    }
}