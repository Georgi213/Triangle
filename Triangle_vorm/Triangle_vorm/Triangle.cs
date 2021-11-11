using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_vorm
{
    class Triangle
    {
        public double a;//первая сторона
        public double b;//вторая сторона
        public double c;//третья сторона
        public double h;//высота
        public Triangle(double A, double B, double C)//конструктор
        {
            a = A;//создаём с заданными длинами сторон согласно заданию
            b = B;
            c = C;
        }
        public Triangle(double A, double H)//конструктор
        {
            a = A;
            h = H;

        }
        public string outputH()
        {
            return Convert.ToString(h);
        }
        public string outputA()// выводим сторону а
        {
            return Convert.ToString(a);//a - ccылка на внутренее поле объекта класса
        }
        public string outputB()// выводим сторону и
        {
            return Convert.ToString(b);
        }
        public string outputC()// выводим сторону с
        {
            return Convert.ToString(c);
        }
        public double Perimeter()// сумма всех сторон типа double
        {
            double p = 0;
            p = a + b + c;//вычисление
            return p;// возврат
        }

        public double Surface()// аналогично периметру..
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;

        }
        public double Ploshadtreugolnika()
        {
            double p = 0;
            double h = 0;
            double S = 0;
            p = (a + b + c) / 2;

            h = 2 * (Math.Sqrt((p * (p - a) * (p - b) * (p - c)))) / a;
            S = (a * h) / 2;
            return S;
        }
        public double GetSetA // свойство позволяющее установить либо изменить значение сторон a
        {
            get
            { return a; }
            set
            { a = value; }

        }
        public double GetSetB// свойство позволяющее установить либо изменить значение сторон b
        {
            get { return b; }
            set { b = value; }

        }
        public double GetSetC // свойство позволяющее установить либо изменить значение сторон c
        {
            get { return c; }
            set { c = value; }

        }
        public bool ExistTriange// свойство позволяющее установить, существует ли треугольник с задаными сторонами
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))//сумма 2 сторон должна быть больше третьей
                    return true;
                else return false;

            }
        }
        public string TriangleType// свойство позволяющее установить, существует ли треугольник с задаными сторонами
        {

            get
            {
                if (ExistTriange)
                {
                    if (a == b && a == c && b == c)
                        return "равносторонний";

                    else if (a == b || a == c || b == c)
                        return "равнобедренный";

                    else return "разносторонний";
                }
                else
                {
                    return "ломаная";
                }
                
            }


        }
    }
}
