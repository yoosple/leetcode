public class Solution 
{
    public int RomanToInt(string s) 
    {
        Dictionary<char, int> simbol = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        int result = 0;
        int n = s.Length;
        for(int i=0; i< n;i++)
        {
            var currentNumber = simbol[s[i]];
            if (i< n-1 && currentNumber < simbol[s[i+1]])
            {
                result -= currentNumber;
            }
            else
            {
                result += currentNumber;
            }
        }
        
        return result;
    }
}