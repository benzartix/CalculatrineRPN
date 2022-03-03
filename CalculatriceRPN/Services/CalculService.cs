using CalculatriceRPN.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatriceRPN.Services
{
    public class CalculService : ICalculService
    {
        public Stack<string> Operation(string[] ArrayInput)
        {
            int n1 = 0;
            int n2 = 0;


            Stack<string> myStack = new Stack<string>();
            myStack.Clear();

            foreach (var item in ArrayInput)
            {
                myStack.Push(item);
            }

            if (myStack.Count != 0) {
                switch (myStack.Peek())
                {
                    case "+":
                        myStack.Pop();
                        n1 = int.Parse(myStack.Pop());
                        n2 = int.Parse(myStack.Pop());
                        myStack.Push((n1 + n2).ToString());
                        break;

                    case "-":
                        myStack.Pop();
                        n1 = int.Parse(myStack.Pop());
                        n2 = int.Parse(myStack.Pop());
                        myStack.Push((n1 - n2).ToString());
                        break;

                    case "*":
                        myStack.Pop();
                        n1 = int.Parse(myStack.Pop());
                        n2 = int.Parse(myStack.Pop());
                        myStack.Push((n1 * n2).ToString());
                        break;

                    case "/":
                        myStack.Pop();
                        n1 = int.Parse(myStack.Pop());
                        n2 = int.Parse(myStack.Pop());

                        if (n2 == 0)
                        {
                            return null;
                        }
                        else
                            myStack.Push((n1 / n2).ToString());
                        break;
                }

            }
            else
            {
                return null;
            }

            return myStack; 
        }
    }
}
