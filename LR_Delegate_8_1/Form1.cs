using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR_Delegate_8_1
{
    public partial class Form1 : Form
    {
        Person person;// Посилання на об'єкт класу Person
        public Form1()
        {
            InitializeComponent();
            person = new Person("Петров", "студент");
            // Додавання елементів у ComboBox при ініціалізації форми
            comboBox1.Items.AddRange(new object[] { "студент", "школяр", "робітник" });
            comboBox1.SelectedIndex = 0; // Встановлення початкового вибору
        }
        // Виклик методу RestMethod
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(person.RestMethod());
        }
        // Зміна статусу
        private void button2_Click(object sender, EventArgs e)
        {
            string newStatus = comboBox1.SelectedItem.ToString();
            person.ChangeStatus(newStatus);
        }
    }
}
