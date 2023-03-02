using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4._3
{
    internal class Student
    {
        // Khai bao bien cua class 
        private string id;
        private string name;
        private int mark;
        private int scholarship;

        // Cac thuoc tinh de truy nhap bien 
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Mark { get => mark; set => mark = value; }

        // property nay khong co set (gan gia tri nhap) vi no dua vao diem de co gia tri, chi can get de dua gia tri no ra
        public int Scholarship
        {
            get
            {
                if (mark > 8)
                    scholarship = 500;
                else if (mark >= 7 && mark <= 8)
                    scholarship = 300;
                else
                    scholarship = 0;
                return scholarship;
            }
        }

        // Create constructor khong tham so
        public Student()
        {
            id = null;
            name = null;
            mark = 0;
        }

        // Create constructor co 1 tham so Id
        public Student(string Id)
        {
            this.Id = Id;
        }

        // Create constructor co tat ca tham so
        public Student(string Id, string Name, int Mark)
        {
            this.Id = Id;
            this.Name = Name;
            this.Mark = Mark;
        }

        // Nap chong phuong thuc la su trung ten phuong thuc nhung khac nhau ve so phuong tham so, vi tri tham so.
    }
}
