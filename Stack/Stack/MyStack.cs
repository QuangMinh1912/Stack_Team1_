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
        private static int giatri;
        private static int sophantu = 3;
        private static int[] Arr = new int[sophantu];//  cấp phát bộ nhớ cho mảng

        public static int Top(int[] Arr)// xuất giá trị cuối cùng của mảng
        {
            return Arr[top];
        }

        public static int Size()
        {
            return top;// hiển thị vị trí cuối cùng của mảng

        }

        public static bool IsFull(int sophantu)
        {
            if (top >= sophantu - 1)//gán độ dài hiện tại của mảng vào biến top
            {
                return true; //độ dài hiện tại của mảng đang là lớn nhất => thì nó đầy
            }
            return false;//độ dài hiện tại của mảng chưa lớn nhất => thì nó chưa đầy
        }

        public static bool IsEmpty()
        {
            if (top == -1)  // kiểm tra vị trí cuối cùng của mảng có = -1 hay kh
            {
                return true; // nếu vị trí cuối cùng = -1 , thì nó trống
            }
            return false; // nếu vị trí cuối cùng không = -1 , thì nó không trống
        }

        public static void Push(int[] Arr, int giatri, int sophantu)//thêm giá trị vào vị trí cuối cùng của mảng
        {
            if (IsFull(sophantu) == true)
            {
                Console.WriteLine("Mảng đã đầy");
            }
            else
            {
                ++top;// tăng top lên 1
                Arr[top] = giatri; // gán giatri vào vị trí cuối cùng hiện tại của mảng
            }
        }

        public static void Pop() // xoá giá trị cuối cùng của mảng
        {
            if (IsEmpty() == true)
            {
                Console.WriteLine("Mảng trống");
            }
            else
            {
                giatri = Arr[top - 1]; //sau khi xóa giá trị cuối , xuất giá trị sau giá trị cuối của mảng
                --top;// giảm top đi 1
            }
        }

        public static void Peek()
        {
            if (IsEmpty() == true)
            {
                Console.WriteLine("Mảng trống");
            }
            else
            {
                Arr[top] = giatri;// gán giatri vào vị trí cuối cùng hiện tại của mảng
            }
        }

        public static void Clear()
        {
            top = -1;// xóa toàn bộ giá trị
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("nhập giá trị ");
                giatri = Int32.Parse(Console.ReadLine());
                Push(Arr, giatri, sophantu);
                Console.WriteLine("Kích thước hiện tại của mảng {0}", Size());
            }

            if (giatri > Arr[top])
            {
                giatri = Arr[top];
            }

            Console.ReadLine();
            Console.WriteLine("Phần tử cuối cùng của mảng là : {0}", Top(Arr));
            Console.ReadLine();

            //Clear();
            //Console.WriteLine("Clear - Kích thước hiện tại của mảng = {0}", Size());

            Peek();// xuất vị trí và giá trị cuối cùng của mảng
            Console.WriteLine("Peek - Kích thước hiện tại của mảng = {0} , giá trị = {1}", Size(), giatri);

            Pop();// xóa giá trị cuối cùng của mảng
            Console.WriteLine("Pop - Kích thước hiện tại của mảng = {0} , giá trị = {1} ", Size(), giatri);

            Clear();//xóa toàn bộ giá trị của mảng
            Console.WriteLine("Clear - Kích thước hiện tại của mảng = {0}", Size());

            Console.ReadLine();
        }
    }
}