using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class MyStack
    {
        private static int top = -1;
        private static int value;
        private static int capacity = 3;
        private static int[] Arr = new int[capacity];

        public static bool IsFull(int capacity)
        {
            if (top >= capacity - 1)
            {
                return true;
            }
            return false;
        }
        public static bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            return false;
        }
        public static void Push(int[] Arr, int value, int capacity)
        {
            if (IsFull(capacity) == true)
            {
                Console.WriteLine("Ngan xep da day . Tinh trang tran");
            }
            else
            {
                ++top;
                Arr[top] = value;
            }
        }
        public static void Pop()
        {
            if (IsEmpty() == true)
            {
                Console.WriteLine("Ngan xep trong rong");
            }
            else
            {
                --top;
            }
        }
        public static int Top(int[] Arr)
        {
            return Arr[top];
        }
        public static int Size()
        {
            return top;
        }
        public static void Peek()
        {
            if (IsEmpty() == true)
            {
                Console.WriteLine("Mang khong co phan tu");
            }
            else
            {
                Arr[top] = value;
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("nhap gia tri bien value ");
                value = Int32.Parse(Console.ReadLine());
                Push(Arr, value, capacity);
                Console.WriteLine("kich thuoc hien tai cua ngan xep {0}", Size());
            }
            Console.ReadLine();
            Console.WriteLine("Phan tu hang dau hien tai cua ngan xep la : {0}", Top(Arr));
            Console.ReadLine();
            
            Peek();
            Console.WriteLine("kich thuoc hien tai cua ngan xep {0}", Size());

                Pop();
                Console.WriteLine("kich thuoc hien tai cua ngan xep {0}", Size());
                Pop();
                Console.WriteLine("kich thuoc hien tai cua ngan xep {0}", Size());
                Pop();
                Console.WriteLine("kich thuoc hien tai cua ngan xep {0}", Size());
                Pop();
                Console.WriteLine("kich thuoc hien tai cua ngan xep {0}", Size());

                Peek();
                Console.WriteLine("kich thuoc hien tai cua ngan xep {0}", Size());
            Console.ReadLine();
        }
    }
}