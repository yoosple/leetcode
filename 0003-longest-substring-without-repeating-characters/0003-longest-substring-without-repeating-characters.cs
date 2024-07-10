public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<int, List<string>> characters = new Dictionary<int, List<string>>();
        int index = 1;

        for (int i = 0; i < s.Length; i++)
        {
            int max = i;
            while (max < s.Length)
            {
                string s2 = s.Substring(max, 1);

                if (!characters.ContainsKey(index))
                {
                    characters.Add(index, new List<string>());
                }

                if (characters[index].Contains(s2))
                {
                    index++;
                    break;
                }
                else
                {
                    characters[index].Add(s2);
                }

                max++;
            }
        }

        if (characters.Count > 0)
        {
            return characters.Max(x => x.Value.Count);
        }

        return 0;
    }
}