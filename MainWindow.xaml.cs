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

namespace LengthCalculator
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string strInput;
        double douOutput;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);

                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);

                txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);

                txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);

                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else
            {
                txtInfo.Text = "輸入錯誤，請輸入數字";
                txtCM.Text = "";
            }

        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text;

            if (double.TryParse(strInput, out douOutput) == true)
            {

                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);

                txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.001);

                txtIn.Text = string.Format("{0:0.##########}", douOutput * 39.37);

                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3.28084);

                txtYard.Text = string.Format("{0:0.##########}", douOutput * 1.09361);
            }
            else
            {
                txtInfo.Text = "輸入錯誤，請輸入數字";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text;

            if (double.TryParse(strInput, out douOutput) == true) 
            { 

                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);

                txtM.Text = string.Format("{0:0.##########}", douOutput * 1000);

                txtIn.Text = string.Format("{0:0.##########}", douOutput * 39370.1);

                txtFt.Text = string.Format("{0:0.##########}", douOutput * 3280.84);

                txtYard.Text = string.Format("{0:0.##########}", douOutput * 1093.61);
            }
            else
            {
                txtInfo.Text = "輸入錯誤，請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            double douIn;

            douIn = Convert.ToDouble(txtIn.Text);

            txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);

            txtM.Text = string.Format("{0:0.##########}", douIn * 0.0254);

            txtKM.Text = string.Format("{0:0.##########}", douIn * 0.00003);

            txtFt.Text = string.Format("{0:0.##########}", douIn * 0.08333);

            txtYard.Text = string.Format("{0:0.##########}", douIn * 0.02778);
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            double douFt;

            douFt = Convert.ToDouble(txtFt.Text);

            txtCM.Text = string.Format("{0:0.##########}", douFt * 30.4801);

            txtM.Text = string.Format("{0:0.##########}", douFt * 0.3048);

            txtKM.Text = string.Format("{0:0.##########}", douFt * 0.00031);

            txtIn.Text = string.Format("{0:0.##########}", douFt * 12);

            txtYard.Text = string.Format("{0:0.##########}", douFt * 0.33333);
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            double douYard;

            douYard = Convert.ToDouble(txtYard.Text);

            txtCM.Text = string.Format("{0:0.##########}", douYard * 91.4402);

            txtM.Text = string.Format("{0:0.##########}", douYard * 0.9144);

            txtKM.Text = string.Format("{0:0.##########}", douYard * 0.00091);

            txtIn.Text = string.Format("{0:0.##########}", douYard * 36);

            txtFt.Text = string.Format("{0:0.##########}", douYard * 3);
        }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
    }
}
