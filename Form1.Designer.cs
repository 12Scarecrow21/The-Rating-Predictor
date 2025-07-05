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
            button1 = new Button();
            txtName = new TextBox();
            txtGenre = new TextBox();
            txtType = new TextBox();
            txtEpisodes = new TextBox();
            txtMembers = new TextBox();
            lblResult = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(362, 118);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnPredict_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(29, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(29, 31);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(100, 23);
            txtGenre.TabIndex = 2;
            // 
            // txtType
            // 
            txtType.Location = new Point(29, 60);
            txtType.Name = "txtType";
            txtType.Size = new Size(100, 23);
            txtType.TabIndex = 3;
            // 
            // txtEpisodes
            // 
            txtEpisodes.Location = new Point(29, 89);
            txtEpisodes.Name = "txtEpisodes";
            txtEpisodes.Size = new Size(100, 23);
            txtEpisodes.TabIndex = 4;
            // 
            // txtMembers
            // 
            txtMembers.Location = new Point(29, 118);
            txtMembers.Name = "txtMembers";
            txtMembers.Size = new Size(100, 23);
            txtMembers.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(240, 2);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(197, 23);
            lblResult.TabIndex = 6;
            lblResult.TextChanged += textBox6_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(txtMembers);
            Controls.Add(txtEpisodes);
            Controls.Add(txtType);
            Controls.Add(txtGenre);
            Controls.Add(txtName);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtName;
        private TextBox txtGenre;
        private TextBox txtType;
        private TextBox txtEpisodes;
        private TextBox txtMembers;
        private TextBox lblResult;
    }
}
