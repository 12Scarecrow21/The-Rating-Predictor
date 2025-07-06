using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Rating_Predictor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            string message = "Введите данные об аниме в соотвествующие строчки :\n" +
                             "- Название (Name)\n" +
                             "- Жанры (Genre) через запятую\n" +
                             "- Тип (TV, Movie и т.д.)\n" +
                             "- Количество серий (Episodes)\n" +
                             "- Количество зрителей (Members)\n\n" +
                             "Затем нажмите кнопку 'Предсказать рейтинг'.";
            MessageBox.Show(message, "Инструкция", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            Form1 mainForm = new Form1();
            mainForm.Show();
            
            this.Hide();  
            
            mainForm.FormClosed += (s, args) => this.Close();
        }
    }
}
