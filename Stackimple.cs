using System;

namespace ImplementStackArray
{
    class Stack
    {
        private int[] element;
        private int top;
        private int max;
        public Stack(int size)
        {
            element = new int[size];
            top  = -1;
            max  = size;
        }

        public void push(int item)
        {
            if (top == max-1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                element[++top] = item;
            }
        }

        public int pop()
        { 
            if(top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element is: " + element[top]);
                return element[top--];
            }
        }

        public void Exe()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + element[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Stack S = new Stack(5);

            S.push(10);
            S.push(20);
            S.push(30);
            S.push(40);
            S.push(50);

            Console.WriteLine("Items are : ");
            S.Exe();

            S.pop();
            S.pop();
            S.pop();
        }
    }
}
