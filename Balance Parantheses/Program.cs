using System;
using System.Collections.Generic;

namespace ANZ
{
    //https://www.hackerrank.com/x/library/hackerrank/all/questions/991413/try
 
    public static class Result
    {
        public static void Main(){
    
        }

        /*
         * Complete the 'minimumSwaps' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING brackets as parameter.
         *
         *
         * A balanced sequence of parentheses is one in which every opening bracket has a corresponding closing bracket to it. More formally, a sequence of parantheses is considered balanced if it can be represented in the form s1(s2) where both s1 and s2 are either empty or balanced strings.   

        Given a sequence of parentheses, find the minimum number of swaps needed to make the sequence balanced. It is not necessary to swap adjacent characters only. If it is impossible to balance the string, return -1.
        
        Example

        brackets = ")()(())("
        brackets = ")))((((("
        brackets = "))()(((("
        brackets = ")(())((("
        brackets = "((()))(("
        brackets = "((()))()"
        brackets = "(()))("

        Swap the characters at the first and last index to get "(()(()))" which is balanced. The string can be balanced with1 swap.
         */

        public static int minimumSwaps(string brackets)
        {
            var chars = new char[brackets.Length];
            for (int i = 0; i < brackets.Length; i++) { 
                chars[i] = brackets[i]; 
            } 
            if (chars.Length % 2==1)
            {
                return -1;
            }

            Stack<char> stack = new Stack<char>();
            
           
            foreach (var c in chars)
            {
            
                
             
                    char val;
                    var tryPeek = stack.TryPeek(out val);
                    
                    stack.Push(c);
                    
                    if (tryPeek && (c==')' && val=='('))
                    {
                        stack.Pop();
                        stack.Pop();
                    }

            }

            return stack.Count / 2 <0?0 : stack.Count / 2;

        }

    }


}