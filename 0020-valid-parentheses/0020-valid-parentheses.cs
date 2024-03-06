public class Solution {
    public bool IsValid(string s) {
        if (string.IsNullOrEmpty(s))
        {
            return false;
        }

        Stack<char> chars = new Stack<char>();

        foreach(char c in s)
        {
            if (c == '(' || c== '[' || c == '{')
            {
                chars.Push(c);
            }
            else
            {
                if (chars.Count == 0)
                {
                    return false;
                }

                char top = chars.Pop();
                char validate;
                switch(top)
                {
                    case '(':
                        validate = ')';

                        break;
                    case '{':
                        validate = '}';

                        break;
                    case '[':
                        validate = ']';

                        break;
                    default:
                        validate = '\0';

                        break;
                }

                if (c != validate)
                {
                    return false;
                }
            }
        }

        return chars.Count == 0;
    }
}