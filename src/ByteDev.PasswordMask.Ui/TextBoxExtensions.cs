using System.Windows.Forms;

namespace ByteDev.PasswordMask.Ui
{
    public static class TextBoxExtensions
    {
        public static bool IsEmpty(this TextBox source)
        {
            return string.IsNullOrEmpty(source.Text);
        }
    }
}