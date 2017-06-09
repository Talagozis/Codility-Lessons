#Code written in C#
#Correctness: 100 %
#Performance: 100 %
#Time Complexity: O(1)
#Space Complexity: O(1)

using System;

class Solution {
    public int solution(int X, int Y, int D) {
                    
        int t = (Y - X) / D;
        
        if((Y - X) % D != 0)
            t ++;
        
        return t;
    }
}
