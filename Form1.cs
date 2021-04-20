using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assistant.Controller;


namespace Assistant
{
    public partial class Form1 : Form
    {
        Query controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            check.CheckName(textBox1.Text, textBox2.Text);
            check.CheckMoney(textBox3.Text);
            if (check.checkname == false)
            {
                MessageBox.Show("   Ім'я та прізвище не можуть мати цифри!", " Некоректно введені дані!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            else
            {

                if (check.checkmoney == false)
                {
                    MessageBox.Show("     Борг не може мати літер!", " Некоректно введені дані!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                }
                else
                {
                    double tb = Convert.ToDouble(textBox3.Text);
                    if (tb < 0)

                    {
                        MessageBox.Show("     Борг не може бути від'ємним!", " Некоректно введені дані!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

                    }
                    else
                    {
                        controller.Add(textBox1.Text, textBox2.Text, tb, false);
                        dataGridView1.DataSource = controller.UpdatePerson();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value.ToString()));
            dataGridView1.DataSource = controller.UpdatePerson();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdatePerson();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void проАвторівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("             Даний програмний засіб створив староста групи ІПЗ19-1(2) - Пирогов Владислав, з метою полегшення своїх обов'язків старости. ", "Про авторів");

        }

        private void інструкціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("             Для занесення данних, введіть правильні значення в кожну колонку, та натисніть клавішу ..Додати..,  після чого дані будуть занесені до таблиці"  + "   \n \n              Щоб видалити дані, оберіть строку яку бажаете видалити, та натисніть кнопку ..Видалити.."  + " \n\n                              Приємного користування!:)   ", "Інструкція");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
