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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double lastNumber, res;
        SelectedOperator selectedOperator;

        public MainWindow()
        {
            InitializeComponent();
            result.Content = 0;
        }

        private void numbersBtn_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            Button btn = sender as Button;
            if (btn != null)
            {
                selectedValue = int.Parse(btn.Content.ToString());
            }

            if (result.Content.ToString() == "0")
            {
                result.Content = $"{selectedValue}";
            }
            else
            {
                result.Content = $"{result.Content}{selectedValue}";
            }
        }

        private void operatorBtn_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(result.Content.ToString(), out lastNumber))
            {
                result.Content = "0";
            }

            if (sender == plusBtn)
                selectedOperator = SelectedOperator.Addition;
            if (sender == minusBtn)
                selectedOperator = SelectedOperator.Substruction;
            if (sender == multiplyBtn)
                selectedOperator = SelectedOperator.Multiplication;
            if (sender == divisionBtn)
                selectedOperator = SelectedOperator.Divide;
        }

        private void acBtn_Click(object sender, RoutedEventArgs e)
        {
            result.Content = "0";
            res = 0;
            lastNumber = 0;

        }

        private void negativeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void percenageBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void pointBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void equalBtn_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if (double.TryParse(result.Content.ToString(), out newNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        res = Calculate.Add(lastNumber, newNumber);
                        break;
                }

                result.Content = res;
            }
        }

        public enum SelectedOperator
        {
            Addition,
            Substruction,
            Multiplication,
            Divide
        }
    }

    public class Calculate
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
