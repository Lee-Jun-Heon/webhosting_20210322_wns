using Class0610_2.model;
using Class0610_2.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610_2.main
{
    class Program
    {
        static void Main(string[] args)
        {
            RandData rand = new RandData();
            Student[] st = new Student[10];
            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new Student(rand.getName(), rand.getAge(),
                    rand.getGender(), rand.getAddress());
                Console.WriteLine(st[i].ToString());
            }

            for (int i = 0; i < st.Length; i++)
            {
                st[9] = new Student("전우치", 24, '남', "조선 한양인근 두메산골");
                Console.WriteLine(st[i].ToString());
            }

        }
    }
}
