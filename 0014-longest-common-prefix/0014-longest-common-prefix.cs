public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
            return string.Empty;

        
        string result = string.Empty;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        string first = strs[0];
        for (int i = 0; i < first.Length; i++)
        {
            dictionary.Add(first.Substring(0, i + 1), 1);
        }

        for (int strsCount = 1; strsCount < strs.Length; strsCount++)
        {
            string second = strs[strsCount];
            for (int j = 0; j < second.Length; j++)
            {
                string s = second.Substring(0, j + 1);
                if (dictionary.ContainsKey(s))
                {
                    dictionary[s]++;
                }
            }
        }

        var prefix = dictionary.LastOrDefault(item => item.Value == strs.Length);
        result = prefix.Key ?? result;        

        return result;
    }
}
