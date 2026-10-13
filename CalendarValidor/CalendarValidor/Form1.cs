using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarValidor
    //VALIDOR JULIANA BSIT 2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CalForm activeCalForm;

        private void OpenForm2(string month)
        {
            try
            {
                if (activeCalForm == null || activeCalForm.IsDisposed)
                {
                    activeCalForm = new CalForm();
                    activeCalForm.Show();
                }

              
                activeCalForm.SetMonthLabel(month);

                if (!string.IsNullOrEmpty(yearTextBox.Text))
                {
                    activeCalForm.SetYearLabel(yearTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        //VALIDOR JULIANA BSIT 2C

        private void janButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text);
            }
        }

        private void febButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text); 
            }
        }

        private void marButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text); 
            }
        }

        private void aprButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text); 
            }
        }

        private void mayButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text); 
            }
        }

        private void junButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text); 
            }
        }

        private void julButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text); 
            }
        }

        private void augButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text); 
            }
        }

        private void septButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text);
            }
        }

        private void octButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text); 
            }
        }

        private void novButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text); 
            }
        }

        private void decButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                OpenForm2(clickedButton.Text); 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //VALIDOR JULIANA BSIT 2C


    }
}