using System.Windows.Forms;

namespace CountryBrowser
{
    public static class Popups
    {
        public static void EmptyTextFieldError()
        {
            MessageBox.Show(
                "Text field is empty. Please enter a country.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static void CountryNotFound()
        {
            MessageBox.Show(                
                $"Make sure you enter correct full name of a country.",
                $"Country not found",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static DialogResult UpdateRequest()
        {
            return
            MessageBox.Show(                
                $"Do you want to update data base?",
                "Success!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
        }

        public static void ErrorMessage(string message)
        {
            MessageBox.Show(
                $"{message}",
                $"Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
