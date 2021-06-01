using System;
using System.Windows;

namespace SyncTestWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                button1.IsEnabled = true;
            }
            if (checkBox2.IsChecked == true)
            {
                button2.IsEnabled = true;
            }
            if (checkBox3.IsChecked == true)
            {
                button3.IsEnabled = true;
            }
            if (checkBox4.IsChecked == true)
            {
                button4.IsEnabled = true;
            }
            if (checkBox5.IsChecked == true)
            {
                button5.IsEnabled = true;
            }
        }

        private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == false)
            {
                button1.IsEnabled = false;
            }
            if (checkBox2.IsChecked == false)
            {
                button2.IsEnabled = false;
            }
            if (checkBox3.IsChecked == false)
            {
                button3.IsEnabled = false;
            }
            if (checkBox4.IsChecked == false)
            {
                button4.IsEnabled = false;
            }
            if (checkBox5.IsChecked == false)
            {
                button5.IsEnabled = false;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 1 was clicked");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 2 was clicked");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 3 was clicked");
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 4 was clicked");
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 5 was clicked");
        }
    }
}
