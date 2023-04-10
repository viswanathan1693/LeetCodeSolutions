namespace LeetCodeSolutions
{
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> mapping = new Dictionary<char, char>()
            {
                {')', '('},
                {']', '['},
                {'}', '{'}
            };

            foreach (char c in s)
            {
                if (mapping.ContainsKey(c))
                {
                    char top = stack.Count > 0 ? stack.Pop() : '#';
                    if (top != mapping[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }
    }
}