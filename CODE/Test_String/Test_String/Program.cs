using System;

namespace Test_String
{
    internal class Program
    {
        //Tính bất biến của chuỗi
        public static void Tinh_Bat_Bien_Cua_Chuoi()
        {
            string a = "Hello";
            string b = a;
             a = a + " World";
            Console.Write(b); // ==> Hello. Do chỉ thay đổi giá trị chuỗi, khi thay đổi thì sẽ tham chiếu vào chuỗi mới chứ, biến b vẫn giữ nguyên
        }

        // Thay thế văn bản bằng Replace()
        public static void Use_Replace()
        {
            string source = "Alo 1 hai ba bon nam sau bay tam";
            string replacement = source.Replace("nam","muoi");
            Console.WriteLine($"The source string is <{source}>");
            Console.WriteLine($"The replacement string <{replacement}>");
        }

        // Dùng phương thức của lớp string cắt bỏ khoảng trắng 
        public static void Use_StringTrim()
        {
            string source = "       Hello a    b c d         ";
            Console.WriteLine($"<{source}>");
            var trimmedResult = source.Trim(); // xóa khoảng cách cả bắt đầu và kết thúc
            var trimLeading = source.TrimStart(); // xóa khoảng cách bắt đầu 
            var trimTrailing = source.TrimEnd(); // xóa khoảng cách kết thúc 

            Console.WriteLine($"<{trimmedResult}>");
            Console.WriteLine($"<{trimLeading}>");
            Console.WriteLine($"<{trimTrailing}>");
        }

        // Xóa văn bản bằng String.Remove() kết hợp với String.IndexOf()
        public static void Use_StringRemove_end_StringIndexOf()
        {
            // có 1 string nguồn
            string source = "Hello 123 anh yeu em, cai gi co";
            // tạo biến string chứa chuỗi cần xóa trong string nguồn
            string toRemove = "anh yeu em";
            // tạo 1 biến chứa string sau khi xóa 1 đoạn từ string nguồn
            string result = string.Empty;
            // tạo biến i để lấy giá trị vị trí xuất hiện từ cần xóa trong đoạn string nguồn
            int i = source.IndexOf(toRemove);
            if(i >= 0)
                result = source.Remove(i, toRemove.Length);
            Console.WriteLine(source);
            Console.WriteLine(result);
        }
        
        // sửa đổi kí tự trong chuỗi ta biến chuổi thành mảng char thông qua String.ToCharArray() và dùng IndexOf() dể tìm vị trí đổi 
        public static void Use_StringToCharArray()
        {
            string source = "Le Ngoc Truong";
            Console.WriteLine(source);
            // tạo biến mảng char chứa đựng xâu khi biến covert thành chuỗi char
            char[] sourceCharArr = source.ToCharArray();
            // tạo biến chỉ vị trí index bắt đầu sửa đổi 
            int index = source.IndexOf("Ngoc");
            // Khi mà tìm được vị trí của từ cần sửa
            if(index != -1)
            {
                sourceCharArr[index++] = 'L';
                sourceCharArr[index++] = 'i';
                sourceCharArr[index++] = 'n';
            }
            string Updatesource = new string(sourceCharArr);
            Console.WriteLine(Updatesource);
        }
        static void Main(string[] args)
        {
            // Tính bất biến của chuỗi 
            //Tinh_Bat_Bien_Cua_Chuoi();
            // Dùng Replace()
            //Use_Replace();
            //Use_StringTrim();
            //Use_StringRemove_end_StringIndexOf();
            Use_StringToCharArray();
            Console.ReadKey();
        }
    }
}
