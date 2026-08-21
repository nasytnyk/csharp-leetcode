// https://leetcode.com/problems/roman-to-integer/?envType=problem-list-v2&envId=dk2wta1c

public class Solution
{
    public int RomanToInt(string s)
    {
        // From back to start
        int indexOfLast = s.Length - 1;

        int sum = 0;
        int prev = 0; // IX = 9, IV = 4

        for(int i = indexOfLast; i >= 0; i--)
        {
            char letter = s[i];
            int number = LetterToNumber(letter);
            if(number >= prev)
            {
                sum += number;
            }
            else
            {
                sum -= number;
            }
            prev = number;
        }
        return sum;
    }

    private int LetterToNumber(char letter) => letter switch 
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => 0
    };
}