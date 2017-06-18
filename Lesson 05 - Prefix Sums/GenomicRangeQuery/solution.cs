
// Code written in C#
// Correctness: 100 %
// Performance: 100 %
// Time Complexity: O(N+M)
// Space Complexity: O(N)

using System;

class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        int[] A = new int[S.Length + 1];
        int[] C = new int[S.Length + 1];
        int[] G = new int[S.Length + 1];
      
        for(int i=0 ; i<S.Length ; i++)
        {
            A[i+1] = A[i] + (S[i] == 'A' ? 1 : 0);
            C[i+1] = C[i] + (S[i] == 'C' ? 1 : 0);
            G[i+1] = G[i] + (S[i] == 'G' ? 1 : 0);
        }
        
        int[] r = new int[P.Length];
        for(int i=0 ; i< P.Length ; i++)
        {
            if(A[P[i]] < A[Q[i]+1])
                r[i] = 1;
            else if(C[P[i]] < C[Q[i]+1])
                r[i] = 2;
            else if(G[P[i]] < G[Q[i]+1])
                r[i] = 3;
            else
                r[i] = 4;
        }
     
        return r;
        }
}