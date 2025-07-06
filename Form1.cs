using static The_Rating_Predictor.MLModel1;
using System.Xml.Linq;

namespace The_Rating_Predictor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnPredict_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка: все поля должны быть заполнены
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtGenre.Text) ||
                    string.IsNullOrWhiteSpace(txtType.Text) ||
                    string.IsNullOrWhiteSpace(txtEpisodes.Text) ||
                    string.IsNullOrWhiteSpace(txtMembers.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                // Создание входной структуры
                var input = new ModelInput()
                {
                    Anime_id = 9999F, // Просто заглушка
                    Name = txtName.Text,
                    Genre = txtGenre.Text,
                    Type = txtType.Text,
                    Episodes = txtEpisodes.Text,
                    Members = txtMembers.Text,
                };

                // Получение предсказания
                var prediction = MLModel1.Predict(input);
                lblResult.Text = $"Прогнозируемый рейтинг: {prediction.Score:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
