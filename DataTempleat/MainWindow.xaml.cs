using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataTempleat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            List<Employee> fruitList = new List<Employee>()
            { new Employee() { Name = "Alex", Dept = "Mechanical", TelephoneNr = "xxx-xxx-xxxxx", EmployeeNr = 11 },
                                            new Employee() { Name = "Mario", Dept = "Electrical", TelephoneNr = "xxx-xxx-xxxxx", EmployeeNr = 12 }};

            InitializeComponent();
            FruitsList.ItemsSource = fruitList;
        }
    }

    internal class Employee
    {
        private string _name;

        private int _employeeNr;

        private string _dept;

        private string _telephoneNr;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int EmployeeNr
        {
            get
            {
                return _employeeNr;
            }

            set
            {
                _employeeNr = value;
            }
        }

        public string Dept
        {
            get
            {
                return _dept;
            }

            set
            {
                _dept = value;
            }
        }

        public string TelephoneNr
        {
            get
            {
                return _telephoneNr;
            }

            set
            {
                _telephoneNr = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }

        //public Employee(string _name, int _employeeNr, string _dept, string _telephoneNr)
        //{
        //    this._name = _name;
        //    this._employeeNr = _employeeNr;
        //    this._dept = _dept;
        //    this._telephoneNr = _telephoneNr;
        //}


    }
}
