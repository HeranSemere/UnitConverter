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

namespace UnitConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox input = this.fromText;
            TextBlock output = this.toText;
            ComboBox fromCombo = this.fromCombo;
            ComboBox toCombo = this.toCombo;
            if (input.Text.ToString() != "" && fromCombo.SelectedIndex > -1 && toCombo.SelectedIndex > -1) { 
            try
            {
                double temp = double.Parse(input.Text);

                switch (fromCombo.SelectedIndex)
                {
                    case 0 when toCombo.SelectedIndex == 0:
                        output.Text = input.Text + " °C";
                        break;
                    case 0 when toCombo.SelectedIndex == 1:
                        output.Text = (temp * 9 / 5 + 32).ToString() + " °F";
                        break;
                    case 0 when toCombo.SelectedIndex == 2:
                        output.Text = (temp + 273.15).ToString() + " °K";
                        break;
                    case 1 when toCombo.SelectedIndex == 0:
                        output.Text = ((temp - 32) * 5 / 9).ToString() + " °C";
                        break;
                    case 1 when toCombo.SelectedIndex == 1:
                        output.Text = input.Text + " °F";
                        break;
                    case 1 when toCombo.SelectedIndex == 2:
                        output.Text = ((temp - 32) * 5 / 9 + 273.15).ToString() + " °K";
                        break;
                    case 2 when toCombo.SelectedIndex == 0:
                        output.Text = (temp - 273.15).ToString() + " °C";
                        break;
                    case 2 when toCombo.SelectedIndex == 1:
                        output.Text = ((temp - 273.15 * 9 / 5) + 32).ToString() + " °F";
                        break;
                    case 2 when toCombo.SelectedIndex == 2:
                        output.Text = input.Text + " °K";
                        break;
                }
            }
            catch
            {
                MessageBox.Show("wrong input ");
            }
            }
            else
            {
                MessageBox.Show("Not a valid input or item not selected.");
            }
            


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox input = this.timeFromText;
            TextBlock output = this.timeToText;
            ComboBox fromCombo = this.timeFromCombo;
            ComboBox toCombo = this.timeToCombo;
            if (input.Text.ToString() != "" && fromCombo.SelectedIndex > -1 && toCombo.SelectedIndex > -1)
            {
                try
                {
                    double time = double.Parse(input.Text);

                    switch (fromCombo.SelectedIndex)
                    {
                        case 0 when toCombo.SelectedIndex == 0:
                            output.Text = input.Text + " sec";
                            break;
                        case 0 when toCombo.SelectedIndex == 1:
                            output.Text = (time / 60).ToString() + " min";
                            break;
                        case 0 when toCombo.SelectedIndex == 2:
                            output.Text = (time / 3600).ToString() + " hr";
                            break;
                        case 1 when toCombo.SelectedIndex == 0:
                            output.Text = (time * 60).ToString() + " sec";
                            break;
                        case 1 when toCombo.SelectedIndex == 1:
                            output.Text = input.Text + " min";
                            break;
                        case 1 when toCombo.SelectedIndex == 2:
                            output.Text = (time / 60).ToString() + " hr";
                            break;
                        case 2 when toCombo.SelectedIndex == 0:
                            output.Text = (time * 3600).ToString() + " sec";
                            break;
                        case 2 when toCombo.SelectedIndex == 1:
                            output.Text = (time * 60).ToString() + " min";
                            break;
                        case 2 when toCombo.SelectedIndex == 2:
                            output.Text = input.Text + " hr";
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("wrong input");
                }
            }    else
            {
                MessageBox.Show("Not a valid input or item not selected.");
            }



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox input = this.weightFromText;
            TextBlock output = this.weightToText;
            ComboBox fromCombo = this.weightFromCombo;
            ComboBox toCombo = this.weightToCombo;
            if (input.Text.ToString() != "" && fromCombo.SelectedIndex > -1 && toCombo.SelectedIndex > -1)
            {
                try
            {
                double weight = double.Parse(input.Text);
                //MessageBox.Show("hey");
                switch (fromCombo.SelectedIndex)
                {
                    case 0 when toCombo.SelectedIndex == 0:
                        output.Text = input.Text + " Kg";
                        break;
                    case 0 when toCombo.SelectedIndex == 1:
                        output.Text = (weight*2.205).ToString() + " lb";
                        break;
                    case 1 when toCombo.SelectedIndex == 0:
                        output.Text = (weight / 2.205).ToString() + " kg";
                        break;
                    case 1 when toCombo.SelectedIndex == 1:
                        output.Text = input.Text + " lb";
                        break;
                }
            }
            catch {
                MessageBox.Show("wrong input");
            }
         } else
            {
                MessageBox.Show("Not a valid input or item not selected.");
            }

}

        private void clear(object sender, RoutedEventArgs e)
        {

            TextBox input = this.fromText;
            TextBlock output = this.toText;
            ComboBox fromCombo = this.fromCombo;
            ComboBox toCombo = this.toCombo;

            TextBox input1 = this.timeFromText;
            TextBlock output1 = this.timeToText;
            ComboBox fromCombo1 = this.timeFromCombo;
            ComboBox toCombo1 = this.timeToCombo;

            TextBox input2 = this.weightFromText;
            TextBlock output2 = this.weightToText;
            ComboBox fromCombo2 = this.weightFromCombo;
            ComboBox toCombo2 = this.weightToCombo;

            input.Clear();
            input1.Clear();
            input2.Clear();

            output.Text="";
            output1.Text = "";
            output2.Text = "";

            fromCombo.SelectedIndex = -1;
            fromCombo1.SelectedIndex = -1;
            fromCombo2.SelectedIndex = -1;

            toCombo.SelectedIndex = -1;
            toCombo1.SelectedIndex = -1;
            toCombo2.SelectedIndex = -1;
        }
    }
}
