using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car0610.CarAppCustomer
{
    class Customer
    {
        private string name;
        private string tel;
        private string address;
        private string model;
        private string color;
        private int year;
        private string company;

        public Customer(string name, string tel, string address, string model, string color, int year, string company)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public string Company { get => company; set => company = value; }

        public void printCustomerInfo()
        {
            Console.WriteLine("고객명 : " + name);
            Console.WriteLine("전화번호 : " + tel);
            Console.WriteLine("주소 : " + address);
            Console.WriteLine("모델명 : " + model);
            Console.WriteLine("색상 : " + color);
            Console.WriteLine("연식 : " + year);
            Console.WriteLine("제조사 : " + company);
            Console.WriteLine("===========================");
        }

        public override string ToString()
        {
            string str = "고객명 : " + name + "\n";
            str += "전화번호 : " + tel + "\n";
            str += "주소 : " + address + "\n";
            str += "모델명 : " + model + "\n";
            str += "색상 : " + color + "\n";
            str += "연식 : " + year + "\n";
            str += "제조사 : " + company + "\n";
            str += "---------------------------\n";
            return str;
        }
    }
}
