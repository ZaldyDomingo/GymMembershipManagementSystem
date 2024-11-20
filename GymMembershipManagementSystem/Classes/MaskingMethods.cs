using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMembershipManagementSystem
{
    public class MaskingMethods
    {
        public static void AddPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }
        public static void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        public static void ValidateNameInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.Handled = true; 
            }

            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Text.EndsWith(" ") && e.KeyChar == ' ')
                {
                    e.Handled = true; 
                }
                if (textBox.Text.EndsWith("-") && e.KeyChar == '-')
                {
                    e.Handled = true;
                }
            }
        }
    }
}
