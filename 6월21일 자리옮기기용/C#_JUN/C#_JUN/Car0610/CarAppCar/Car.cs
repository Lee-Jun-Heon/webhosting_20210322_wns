using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car0610.CarAppCar
{
    class Car
    {
        private string model;
        private string color;
        private int year;
        private string company;

        public Car(string model, string color, int year, string company)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public string Company { get => company; set => company = value; }

        public void printCarInfo()
        {
            Console.WriteLine("모델명 : " + model);
            Console.WriteLine("색상 : " + color);
            Console.WriteLine("연식 : " + year);
            Console.WriteLine("제조사 : " + company);
            Console.WriteLine("===========================");
        }

        public override string ToString()
        {
            string str = "모델명 : " + model + "\n";
            str += "색상 : " + color + "\n";
            str += "연식 : " + year + "\n";
            str += "제조사 : " + company + "\n";
            str += "---------------------------\n";
            return str;
        }
    }

}
