// See https://aka.ms/new-console-template for more information
namespace BAITAP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ten la Nguyen Thi Khanh Ly");
            string name = " Nguyen Thi    Khanh Ly";
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Lỗi: Chuỗi rỗng hoặc null!");
                return;
            }
            string[] a = name.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < a.Length; i++)
                a[i] = char.ToUpper(a[i][0]) + a[i].Substring(1).ToLower();
            string tenChuanHoa = string.Join(" ", a);
            Console.WriteLine("Bai 1: Họ tên sau khi chuẩn hóa là: " + tenChuanHoa);
            Console.WriteLine("Bai 2: Số từ trong chuỗi là: " + a.Length);
            //Bai3
            string s = tenChuanHoa.Replace(" ", "");

            bool doiXung = true;
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    doiXung = false;
                    break;
                }
                left++;
                right--;
            }

            if (doiXung)
                Console.WriteLine("Bai 3: Chuỗi là đối xứng");
            else
                Console.WriteLine("Bai 3: Chuỗi không đối xứng");

        }


    }
}
