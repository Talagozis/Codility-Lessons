// Code written in C#
// Correctness: 100 %
// Performance: 88 %
// Time Complexity: O(N)
// Space Complexity: O(1)

using System;

class Solution {
    public int solution(int[] A) {
        
        int length = A.Length;         
 
        int[] count = new int[length];
        for (int i=0 ; i<length ; i++)
            count[i] = 0;

        for (int i=0 ; i<length ; i++)
            if(A[i] < length && A[i] > 0)
                count[A[i]]++; 

        for (int i=1 ; i<length ; i++)
            count[i] += count[i-1];

        int[] output = new int[length];
        for (int i=0 ; i<length ; i++)
        {
            if(A[i] < length && A[i] > 0)
            {
                output[count[A[i]]-1] = A[i];
                count[A[i]]--;
            }
        }            
        
        if(output[0] > 1)
            return 1;
            
        if (output[length - 1] < 0) 
            return 1; 
            
        for(int i = 1 ; i<length ; i++)
        {
            if(output[i] - output[i-1] > 1 || output[i] - output[i-1] < 0 )
                return output[i-1] + 1;
        }
        
        return output[length - 1] + 1;
    }
}

using System;

class Solution {
    public int solution(int[] A) {
        
        int length = A.Length;
        
        bool[] b = new bool[length];
        for(int i = 0 ; i < length ; i++)
            b[i] = false;
        
        for(int i = 0 ; i < length ; i++)
        {
            if(A[i] > 0 && A[i] <= length)
            {
                b[A[i]-1] = true;
            }              
        }
        
        for(int i = 0 ; i < length ; i++)
        {
            if(!b[i])
            {
                return i+1;
            }              
        }        
        
        return A[length -1] +1;
    }
}