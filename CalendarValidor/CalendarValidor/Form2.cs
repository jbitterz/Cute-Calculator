using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarValidor
//VALIDOR JULIANA BSIT 2C
{
    public partial class CalForm : Form
    {
        private string yearText;  
        private string monthText; 

        public CalForm()
        {
            InitializeComponent();
        }

        public void SetLabelText(string text)
        {
            yearText = text;  
            monthText = text; 
            label1.Text = text;
            yearTextBox.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(monthText))
            {
                label1.Text = $"{monthText}";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            yearTextBox.Text = $" {yearText}";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.HideSelection = false; 
            listView1.SelectedIndices.Clear(); 
        }

        public void SetMonthLabel(string text)
        {
            monthText = text;
            label1.Text = text;
            UpdateCalendar(); 
        }

        public void SetYearLabel(string text)
        {
            if (!int.TryParse(text, out int year))
            {
                return; 
            }

            yearText = text;
            yearTextBox.Text = text;
            UpdateCalendar(); 
        }
        //VALIDOR JULIANA BSIT 2C
        private void UpdateCalendar()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Clear();

          
            string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            foreach (string day in days)
            {
                listView1.Columns.Add(day, 50);
            }

           
            if (!int.TryParse(yearText, out int year))
            {
                return; 
            }
            if (string.IsNullOrEmpty(monthText))
            {
                return; 
            }

            int month;
            try
            {
                month = DateTime.ParseExact(monthText, "MMMM", CultureInfo.InvariantCulture).Month;
            }
            catch
            {
                return; 
            }

            int daysInMonth = DateTime.DaysInMonth(year, month);
            int firstDayOfWeek = (int)new DateTime(year, month, 1).DayOfWeek;
            firstDayOfWeek = (firstDayOfWeek == 0) ? 6 : firstDayOfWeek - 1; 

            ListViewItem currentRow = new ListViewItem(new string[7]);

            // Fill in empty slots before the first day
            for (int i = 0; i < firstDayOfWeek; i++)
            {
                currentRow.SubItems[i].Text = "";
            }

            // Fill in the actual days
            for (int day = 1; day <= daysInMonth; day++)
            {
                currentRow.SubItems[firstDayOfWeek].Text = day.ToString();
                firstDayOfWeek++;

                if (firstDayOfWeek == 7) // New week
                {
                    listView1.Items.Add(currentRow);
                    currentRow = new ListViewItem(new string[7]);
                    firstDayOfWeek = 0;
                }
            }

            if (firstDayOfWeek > 0)
            {
                listView1.Items.Add(currentRow);
            }
        }//VALIDOR JULIANA BSIT 2C
    }
}
