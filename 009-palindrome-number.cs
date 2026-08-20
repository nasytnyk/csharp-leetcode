// https://leetcode.com/problems/palindrome-number/?envType=problem-list-v2&envId=dk2wta1c

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        /*
            11 / 10 = 1
            9 / 10 = 0
        */

        int copy = x;
        long reversed = 0;

        while (copy > 0)
        {
            reversed *= 10; 
            reversed += copy % 10;
            copy /= 10; 
        }

        return reversed == x;
    }
}