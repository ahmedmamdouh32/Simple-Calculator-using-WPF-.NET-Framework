using System.Windows;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {

        bool mul_rb_pressed = false;
        bool div_rb_pressed = false;
        bool add_rb_pressed = false;
        bool sub_rb_pressed = false;
        public MainWindow()
        {
            
            InitializeComponent();
            resultText.Text = "0000";


        }

       

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
           
        }



        private void calculateButtonClicked(object sender, RoutedEventArgs e)
        {
            if (firstNumberBox.Text == "" || secondNumberBox.Text == "")
            {
                resultText.Text = "Enter Numbers";
            }
            else
            {
                float result = 0;
                if (mul_rb_pressed == true)
                {
                    result = float.Parse(firstNumberBox.Text) * float.Parse(secondNumberBox.Text);
                    string result_str = result.ToString();
                    resultText.Text = result_str;
                }
                else if (div_rb_pressed == true)
                {
                    if (float.Parse(firstNumberBox.Text) == 0)
                    {
                        resultText.Text = "Error";
                    }
                    else
                    {
                        result = float.Parse(firstNumberBox.Text) / float.Parse(secondNumberBox.Text);
                        string result_str = result.ToString();
                        resultText.Text = result_str;
                    }
                }
                else if (add_rb_pressed == true)
                {
                    result = float.Parse(firstNumberBox.Text) + float.Parse(secondNumberBox.Text);
                    string result_str = result.ToString();
                    resultText.Text = result_str;
                }
                else if (sub_rb_pressed == true)
                {
                    result = float.Parse(firstNumberBox.Text) - float.Parse(secondNumberBox.Text);
                    string result_str = result.ToString();
                    resultText.Text = result_str;
                }
                else
                {
                    resultText.Text = "Enter Opeartion";
                }

            }

        }

        private void multiplyRadioButtonClicked(object sender, RoutedEventArgs e)
        {
            mul_rb_pressed = true;
            div_rb_pressed = false;
            add_rb_pressed = false;
            sub_rb_pressed = false;    
        }

        private void substractRadioButtonClicked(object sender, RoutedEventArgs e)
        {
            mul_rb_pressed = false;
            div_rb_pressed = false;
            add_rb_pressed = false;
            sub_rb_pressed = true;
        }

        private void addRadioButtonClicked(object sender, RoutedEventArgs e)
        {
            mul_rb_pressed = false;
            div_rb_pressed = false;
            add_rb_pressed = true;
            sub_rb_pressed = false;
        }

        private void divideRadioButtonClicked(object sender, RoutedEventArgs e)
        {
            mul_rb_pressed  = false;
            div_rb_pressed  = true;
            add_rb_pressed  = false;
            sub_rb_pressed  = false;
        }

        private void clearButtonClicked(object sender, RoutedEventArgs e)
        {
            firstNumberBox.Clear();
            secondNumberBox.Clear();
        }
    }
}