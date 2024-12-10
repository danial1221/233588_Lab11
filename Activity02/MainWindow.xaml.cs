using System.Windows;

namespace WPFCheckBoxControl
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            if (sender == checkBox1)
                textBox1.Text = "Two States Checked";
            else if (sender == checkBox2)
                textBox2.Text = "Three States Checked";
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            if (sender == checkBox1)
                textBox1.Text = "Two States Unchecked";
            else if (sender == checkBox2)
                textBox2.Text = "Three States Unchecked";
        }

        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            textBox2.Text = "Three States Indeterminate";
        }
    }
}
