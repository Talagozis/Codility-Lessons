// Code written in Java
// Correctness: 100 %
// Performance: 100 %
// Time Complexity: O(1)
// Space Complexity: O(1)

class Solution {
    public int solution(int A, int B, int K) {
        
        int l = A % K;
        
        if (l == 0)
            return (B - A) / K +1;
            
        if(A+(K-l) > B)
            return 0;
            
        return (B - (A+(K-l))) / K  + 1;
    }
}