using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarLibrary;

namespace pract_5
{
    public partial class Form1 : Form
    {

        public List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            cars.Add(car);
            string txt = car.SetParams(markAuto.Text, (int)countCylinders.Value, (int)powerAuto.Value);
            listBox.Items.Add(txt);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            cars[listBox.SelectedIndex] = car;
            try
            {
                listBox.Items[listBox.SelectedIndex] = car.SetParams(markAuto.Text, (int)countCylinders.Value, (int)powerAuto.Value);
            }
            catch
            {
                MessageBox.Show("Элемент списка не выбран");
            }            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                cars.RemoveAt(listBox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Элемент списка не выбран");
            }
        }

        private void AddOnlyMark_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            cars.Add(car);
            listBox.Items.Add(car.SetParams(markAuto.Text));
        }

        private void AddOnlyCylinders_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            cars.Add(car);
            listBox.Items.Add(car.SetParams((int)countCylinders.Value));
        }

        private void AddMarkPower_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            cars.Add(car);
            listBox.Items.Add(car.SetParams((int)powerAuto.Value, markAuto.Text));
        }

        private void AddMarkCylinders_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            cars.Add(car);
            listBox.Items.Add(car.SetParams(markAuto.Text, (int)countCylinders.Value));
        }

        private void AddCylindersPower_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            cars.Add(car);
            listBox.Items.Add(car.SetParams((int)countCylinders.Value, (int)powerAuto.Value));
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк ИСП-31, вариант 1. Создать базовый класс Саr (машина), характеризуемый торговой маркой (строка), числом цилиндров, мощностью. Создать необходимые методы и свойства. Создать перегруженные методы SetParams, для установки параметров автомобиля. ");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            cars.Clear();
        }

        private void CompareAutos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cars[(int)firstAuto.Value] > cars[(int)secondAuto.Value]);
        }
    }
}
