#Code written in C#
#Correctness: 100 %
#Performance: 100 %
#Time Complexity: O(N)
#Space Complexity: O(1)

using System;

class Solution {
    public int solution(int[] A) {
        
        long s = 0;
        
        foreach(long i in A)
            s = s + i;
        
        for(long i = 1 ; i <= A.Length +1 ; i++)
            s = s - i;
            
        return (int)-s;
        
    }
}