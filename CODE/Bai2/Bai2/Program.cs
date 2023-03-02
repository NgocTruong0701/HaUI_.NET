namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[3] { "Le Ngoc Truong", "Nguyen Linh Truong", "Nguyen Thi Thuy Linh" };
            for (int i = 0; i < name.Length; i++)
                Console.WriteLine(name[i]);
            
            // Ham sap xep theo ABC 
            Array.Sort(name);
            //Ham dao nguoc vi tri cac phan tu trong mang 
            Array.Reverse(name);

            // Dùng hàm foreach để lấy ra từng phần tử 
            foreach(string s in name)
                Console.WriteLine(s);
            // Ấn để thoát
            Console.ReadKey();
        }
    }
}