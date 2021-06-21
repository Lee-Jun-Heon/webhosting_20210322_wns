using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610
{
    class Car2
    {
        //클래스 변수
        public const string JIJUM = "동대구영업소";

        //인스턴스 변수
        private string company;
        private string color;
        private string model;
        private string price;

        public string Company { get => company; set => company = value; }
        public string Color { get => color; set => color = value; }
        public string Model { get => model; set => model = value; }
        public string Price { get => price; set => price = value; }

        public Car2(string company, string color, string model, string price)
        {
            this.company = company;
            this.color = color;
            this.model = model;
            this.price = price;
        }

        public void printCarInfo()
        {
            Console.WriteLine("제조사 : " + company);
            Console.WriteLine("색상 : " + color);
            Console.WriteLine("모델 : " + model);
            Console.WriteLine("가격 : " + price);
        }

        public override string ToString()
        {
            string str = "제조사 : " + company + "\n";
            str += "색상 : " + color + "\n";
            str += "모델 : " + model + "\n";
            str += "가격 : " + price + "\n";
            return str;
        }


    }
}
