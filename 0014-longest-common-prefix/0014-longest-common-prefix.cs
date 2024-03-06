public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int total = strs.Length;
        string result = string.Empty;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        if (total > 0)
        {
            string first = strs[0];
            for (int i = 0; i < first.Length; i++)
            {
                dictionary.Add(first.Substring(0, i + 1), 1);
            }

            for (int strsCount = 1; strsCount < total; strsCount++)
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

            var prefix = dictionary.LastOrDefault(item => item.Value == total);
            result = prefix.Key ?? result;
        }

        return result;
    }
}