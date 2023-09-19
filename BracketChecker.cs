using System;

namespace C__2023__КН_22_
{
    public static class BracketChecker
    {
        #region FindMethod
        public static bool CheckAccordance(string userString, out int ErrorPosotion)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = userString.Length - 1; 0 <= i; --i)
            {
                switch (userString[i])
                {
                    case '}':
                    case ']':
                    case ')':
                        stack.Push(userString[i]);
                        break;
                    case '{':
                        if (stack.Peek() == '}') stack.Pop();
                        else
                        {
                            ErrorPosotion = i + 1;
                            return false;
                        }
                        break;
                    case '[':
                        if (stack.Peek() == ']') stack.Pop();
                        else
                        {
                            ErrorPosotion = i + 1;
                            return false;
                        }
                        break;
                    case '(':
                        if (stack.Peek() == ')') stack.Pop();
                        else
                        {
                            ErrorPosotion = i + 1;
                            return false;
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong sign in input string!");
                        ErrorPosotion = i + 1;
                        return false;
                }
            }
            if (stack.IsEmpty())
            {
                ErrorPosotion = 0;
                return true;
            }
            else
            {
                ErrorPosotion = 0;
                return false;
            }
        }
        #endregion
    }
}