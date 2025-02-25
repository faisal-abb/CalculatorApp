using System;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double result = NativeMethods.add(a, b);
                ResultLabel.Text = $"Result: {result}";
            }
        }

        private void OnSubtractClicked(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double result = NativeMethods.subtract(a, b);
                ResultLabel.Text = $"Result: {result}";
            }
        }

        private void OnMultiplyClicked(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                double result = NativeMethods.multiply(a, b);
                ResultLabel.Text = $"Result: {result}";
            }
        }

        private void OnDivideClicked(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
            {
                try
                {
                    double result = NativeMethods.divide(a, b);
                    ResultLabel.Text = $"Result: {result}";
                }
                catch (Exception ex)
                {
                    ResultLabel.Text = "Error: " + ex.Message;
                }
            }
        }

        private bool TryGetInputs(out double a, out double b)
        {
            bool validA = double.TryParse(EntryA.Text, out a);
            bool validB = double.TryParse(EntryB.Text, out b);

            if (!validA || !validB)
            {
                ResultLabel.Text = "Invalid input";
                return false;
            }
            return true;
        }
    }

}
