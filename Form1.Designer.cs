namespace The_Rating_Predictor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            txtGenre = new TextBox();
            txtType = new TextBox();
            txtEpisodes = new TextBox();
            txtMembers = new TextBox();
            lblResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(155, 201);
            button1.Name = "button1";
            button1.Size = new Size(210, 23);
            button1.TabIndex = 0;
            button1.Text = "Предсказать рейтинг";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnPredict_Click;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(12, 117);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(100, 23);
            txtGenre.TabIndex = 2;
            // 
            // txtType
            // 
            txtType.Location = new Point(12, 186);
            txtType.Name = "txtType";
            txtType.Size = new Size(100, 23);
            txtType.TabIndex = 3;
            // 
            // txtEpisodes
            // 
            txtEpisodes.Location = new Point(12, 250);
            txtEpisodes.Name = "txtEpisodes";
            txtEpisodes.Size = new Size(100, 23);
            txtEpisodes.TabIndex = 4;
            // 
            // txtMembers
            // 
            txtMembers.Location = new Point(12, 327);
            txtMembers.Name = "txtMembers";
            txtMembers.Size = new Size(100, 23);
            txtMembers.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(155, 160);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(210, 23);
            lblResult.TabIndex = 6;
            lblResult.TextChanged += textBox6_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 7;
            label1.Text = "Название аниме";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 8;
            label2.Text = "Жанры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 9;
            label3.Text = "Тип ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(12, 232);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 10;
            label4.Text = "Количество серий";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Location = new Point(12, 309);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 11;
            label5.Text = "Количество зрителей";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(555, 410);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResult);
            Controls.Add(txtMembers);
            Controls.Add(txtEpisodes);
            Controls.Add(txtType);
            Controls.Add(txtGenre);
            Controls.Add(button1);
            Name = "Form1";
            Text = "The Rating Predictor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtGenre;
        private TextBox txtType;
        private TextBox txtEpisodes;
        private TextBox txtMembers;
        private TextBox lblResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
    }
}
