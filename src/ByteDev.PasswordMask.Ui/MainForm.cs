using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ByteDev.Common;
using ByteDev.PwnedPasswords;

namespace ByteDev.PasswordMask.Ui
{
    public partial class MainForm : Form
    {
        private const char PasswordChar = '\u2022';

        private bool IsMaskEnabled => passwordTextBox.PasswordChar == PasswordChar;

        public MainForm()
        {
            InitializeComponent();
            MaximumSize = Size;
            MinimumSize = Size;
        }

        private void PastePassword()
        {
            passwordTextBox.Text = Clipboard.GetText();
        }

        private void SetOutput()
        {
            output1TextBox.Text = firstNumberTextBox.IsEmpty() ? string.Empty : passwordTextBox.Text.SafeSubstring(GetStartIndex(firstNumberTextBox), 1);
            output2TextBox.Text = secondNumberTextBox.IsEmpty() ? string.Empty : passwordTextBox.Text.SafeSubstring(GetStartIndex(secondNumberTextBox), 1);
            output3TextBox.Text = thirdNumberTextBox.IsEmpty() ? string.Empty : passwordTextBox.Text.SafeSubstring(GetStartIndex(thirdNumberTextBox), 1);
            output4TextBox.Text = fourthNumberTextBox.IsEmpty() ? string.Empty : passwordTextBox.Text.SafeSubstring(GetStartIndex(fourthNumberTextBox), 1);
        }

        private int GetStartIndex(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = @"1";
                return 1;
            }
            var index = Convert.ToInt32(textBox.Text);

            if (index < 1)
            {
                textBox.Text = @"1";
                return 1;
            }

            return index - 1;
        }

        private void EnableMask()
        {
            passwordTextBox.PasswordChar = PasswordChar;
        }

        private void DisableMask()
        {
            passwordTextBox.PasswordChar = '\0';
        }

        private void ToggleMask()
        {
            if (IsMaskEnabled)
                DisableMask();
            else
                EnableMask();
        }

        private void UpdateStatusToPasswordLength()
        {
            passwordLengthToolStripStatusLabel.Text = $"{passwordTextBox.Text.Length} ch";
        }

        private void UpdateStatus(string text)
        {
            generalStatusLabel.Text = text;
        }

        private void UpdateStatus()
        {
            UpdateStatus(string.Empty);
        }
        
        private async Task CheckPassword()
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text))
                return;

            var client = new PwnedPasswordsClient();

            UpdateStatus("Checking if pwned...");

            try
            {
                var response = await client.GetHasBeenPwnedAsync(new HashedPassword(passwordTextBox.Text));

                if (response.IsPwned)
                {
                    MessageBox.Show($"Password has been pwned {response.Count} times before.", "Pwned Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Password has yet to be pwned.", "Pwned Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (PwnedPasswordsClientException ex)
            {
                MessageBox.Show($"Problem while checking password.\n\nError Message:\n{ex.Message}", "Pwned Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UpdateStatus();
            }
        }

        #region Event Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateStatus($"v{Application.ProductVersion}");

            EnableMask();
            PastePassword();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clipboard.Clear();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            SetOutput();
            UpdateStatusToPasswordLength();
        }

        private void firstNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            SetOutput();
        }

        private void secondNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            SetOutput();
        }

        private void thirdNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            SetOutput();
        }

        private void fourthNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            SetOutput();
        }

        private void firstNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            firstNumberTextBox.SelectAll();
        }

        private void secondNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            secondNumberTextBox.SelectAll();
        }

        private void thirdNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            thirdNumberTextBox.SelectAll();
        }

        private void fourthNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            fourthNumberTextBox.SelectAll();
        }
        
        private void pasteButton_Click(object sender, EventArgs e)
        {
            PastePassword();
        }

        private void eyePictureBox_Click(object sender, EventArgs e)
        {
            ToggleMask();
        }

        private async void checkPasswordButton_Click(object sender, EventArgs e)
        {
            await CheckPassword();
        }

        #endregion
    }
}
