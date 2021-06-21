using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0610
{
    class Car
    {
        //클래스 변수
        public const string JIJUM = "동대구영업소";

        //인스턴스 변수
        private string company;
        private string color;
        private string model;
        private string price;

        public Car()
        {
            company = "기아";
            color = "블랙";
            model = "K7";
            price = "4천만원";
        }

        public Car(string company, string color, string model, string price)
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

        public void setModel(string model)
        {
            this.model = model;
        }

        public void setPrice(string price)
        {
            this.price = price;
        }

        public string getModel()
        {
            return model;
        }

        public string getPrice()
        {
            return price;
        }


    }
}
