using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic0609
{
    class Program
    {
        /// <summary>
        /// 메인 함수
        /// </summary>
        /// <param name="args">메인함수 매개변수</param>
        static void Main(string[] args) //클래스 메소드
        {
            //출력
            Console.Write("Hello C#");  //개행미포함
            Console.WriteLine("\tHello World");  //개행

            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.WriteLine("이름 : " + name);

            Console.Write("나이 입력 : ");
            //string age = Console.ReadLine();
            //int nAge = Convert.ToInt32(age);  //문자를 숫자로 변환
            int age = Convert.ToInt32(Console.ReadLine()); //문자를 숫자로 한번에 변환
            Console.WriteLine("나이 : {0}", age);
            Console.WriteLine("나이 : {0}, 이름 : {1}", age, name);

            string str = string.Format("이름 : {0}, 나이 : {1}", name, age);
            Console.WriteLine(str);


        }
    }
}
