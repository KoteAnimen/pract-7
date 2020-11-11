using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        public  string MarkAuto { get; set; }
        public  int CountCylinders { get; set; }
        public  int Power { get; set; }


        public static string operator <(Car car1, Car car2)
        {
            if (car1.CountCylinders < car2.CountCylinders && car1.Power < car2.Power)
            { 
                return car2.MarkAuto + " круче чем " + car1.MarkAuto;
            }
            if (car1.CountCylinders == car2.CountCylinders && car1.Power == car2.Power)
            {
                return car1.MarkAuto + " равна " + car2.MarkAuto;
            }
            else return car1.MarkAuto + " круче чем " + car2.MarkAuto;
        }
        public static string operator >(Car car1, Car car2)
        {
            if (car1.CountCylinders > car2.CountCylinders && car1.Power > car2.Power)
            {
                return car1.MarkAuto + " круче чем " + car2.MarkAuto;                
            }
            if (car1.CountCylinders == car2.CountCylinders && car1.Power == car2.Power)
            {
                return car1.MarkAuto + " равна " + car2.MarkAuto;
            }
            else return car2.MarkAuto + " круче чем " + car1.MarkAuto;
        }

        public string SetParams(string mark, int cylinders, int power) //функция установки параметров автомобиля(марка, цилиндры, мощность). 
        {
            MarkAuto = mark;
            CountCylinders = cylinders;
            Power = power;
            return "Машина марки " + MarkAuto + " с количеством цилиндров " + CountCylinders.ToString() + " мощностью " + Power.ToString() + " лошадей";
        }

        public string SetParams(string mark) //перегрузка функции SetParams с аргументом марка.
        {
            MarkAuto = mark;            
            return "Машина марки " + MarkAuto ;
        }
        // остальные перегрузки функции SetParams()
        public string SetParams(int cylinders)
        {
            CountCylinders = cylinders;            
            return "Количество цилиндров " + CountCylinders.ToString();
        }
        
        public string SetParams(string mark, int cylinders)
        {
            MarkAuto = mark;
            CountCylinders = cylinders;
            return "Машина марки " + MarkAuto + " с количеством цилиндров " + CountCylinders.ToString();
        }

        public string SetParams(int cylinders, int power)
        {
            CountCylinders = cylinders;
            Power = power;
            return " Количество цилиндров " + CountCylinders.ToString() + " мощностью " + Power.ToString() + " лошадей";
        }

        public string SetParams(int power, string mark)
        {
            MarkAuto = mark;            
            Power = power;
            return "Машина марки " + MarkAuto + " мощностью " + Power.ToString() + " лошадей";
        }
        
        
    }

    public class Lorry : Car //класс описывающий грузовик, являющийся наследником от класса  Car
    {
        public int Capacity { get; set; } // свойство обозначающее грузоподъемность

        public new void SetParams(string mark, int cylinders, int power)
        {
            MarkAuto = mark;
            CountCylinders = cylinders;
            Power = power;            
        }

        public new void SetParams(int capacity)
        {
            Capacity = capacity;
        }

        public string GetParams()
        {
            return "Грузовик марки " + MarkAuto + " с количеством цилиндров " + CountCylinders.ToString() + " мощностью " + Power.ToString() + " лошадей с грузоподъемностью " + Capacity ;
        }

    }
}
