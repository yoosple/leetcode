public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }
        
        string s = x.ToString();
        string revers = "";
        for(int i=s.Length-1; i >= 0; i --)
        {
            revers += s[i];
        }
        
        if(double.Parse(revers) > int.MaxValue)
        {
            return false;
        }
        
        return x == int.Parse(revers);
    }
}