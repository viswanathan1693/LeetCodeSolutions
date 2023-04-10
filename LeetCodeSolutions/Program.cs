using LeetCodeSolutions;

string s = "()[]{}";
bool isValid = ValidParentheses.IsValid(s);
Console.WriteLine("The string " + s + " is " + (isValid ? "valid" : "invalid"));

Console.ReadKey();