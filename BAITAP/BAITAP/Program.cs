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
            Bai4_5_6();
            Bai7();
            Bai8();
            Bai9();

        }

        static void Bai4_5_6()
        {
            Console.WriteLine("Bai 4,5,6: Nhap so phan tu: ");
            int spt = int.Parse(Console.ReadLine());
            int[] arr = new int[spt];
            Console.WriteLine("Nhap cac phan tu: ");
            for (int i = 0; i < spt; i++)
            {
                Console.WriteLine($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (arr == null)
            {
                Console.WriteLine("Mang chua khoi tao");
                return;
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Bai 4: Tong cac phan tu mang la: " + sum);
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine("Bai 5: Max = " + max);
            int demChan = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                    demChan++;
            Console.WriteLine("Bai 6: So phan tu chan trong mang la: " + demChan);
        }
        static void Bai7()
        {
            Console.WriteLine("Bai 7: Nhap chuoi");
            String chuoi = Console.ReadLine();
            if (chuoi == null)
            {
                Console.WriteLine("Chuoi null-khong tach");
                return;
            }
            string[] arrName = chuoi.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (arrName == null)
            {
                Console.WriteLine("Mảng kết quả null - không in!");
                return;
            }

            Console.WriteLine("Bai 7 - Các tu trong ho ten:");

            for (int i = 0; i < arrName.Length; i++)
                Console.WriteLine(arrName[i]);

            Console.WriteLine();


        }
        static void Bai8()
        {
            Console.WriteLine("Bai 8: Nhap vao cau: ");
            String sentence = Console.ReadLine();
            if (sentence == null)
            {
                Console.WriteLine("Chuoi null");
                return;
            }
            string[] words = sentence.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                Console.WriteLine("Không có từ!");
                return;
            }

            string longest = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longest.Length)
                    longest = words[i];
            }

            Console.WriteLine("Ket qua bai 8: Tu dai nhat la: " + longest);
            Console.WriteLine();
        }

        static void Bai9()
        {
            Console.Write("Bai 9: Nhap chuoi: ");
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Chuỗi null - không xử lý!");
                return;
            }

            string[] arr = input.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (arr == null)
            {
                Console.WriteLine("Mảng null - không xử lý!");
                return;
            }

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(arr[i]))
                    count++;
            }

            Console.WriteLine("Ket qua bai 9: So chuoi khac null va khac rong la: " + count);
        }
    }
}
