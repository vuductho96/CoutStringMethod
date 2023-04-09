using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi: ");
        string str = Console.ReadLine();

        Console.Write("Nhap ky tu: ");
        char ch = Console.ReadKey().KeyChar;// phương thức ReadKey nhận vào ký tự từ phàn phím .và xử ký đối tượng kiểu char
        Console.WriteLine();

        int count = 0;
        foreach (char c in str)
        {
            if (c == ch)
            {
                count++;
            }
        }

        Console.WriteLine("So lan xuat hien cua ky tu '{0}' trong chuoi la: {1}", ch, count);
    }
}
