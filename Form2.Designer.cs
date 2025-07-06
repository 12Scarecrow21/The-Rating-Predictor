namespace The_Rating_Predictor
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(458, 196);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Далее";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnNext_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 82);
            label2.Name = "label2";
            label2.Size = new Size(446, 15);
            label2.TabIndex = 2;
            label2.Text = "Суть данного приложения в предсказании рейтинга аниме по вашему запросу \r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 119);
            label3.Name = "label3";
            label3.Size = new Size(505, 15);
            label3.TabIndex = 3;
            label3.Text = "Если вам нужно ознакомиться с функционалом приложения нажмите кнопку \"Помощь\" ";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(28, 196);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Помощь";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnHelp_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 159);
            label4.Name = "label4";
            label4.Size = new Size(303, 15);
            label4.TabIndex = 5;
            label4.Text = "Если же вы готовы к предсказанию нажмите \"Далее\" ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 33);
            label1.Name = "label1";
            label1.Size = new Size(196, 30);
            label1.TabIndex = 6;
            label1.Text = "              Добро пожаловать\r\nв приложение The Rating Predictor";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(546, 242);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "The Rating Predictor";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label label1;
    }
}