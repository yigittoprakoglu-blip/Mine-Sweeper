namespace Mayın_Tarlası
{
    partial class WelcomeForm
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
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(94, 92);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 0;
            button1.Text = "Kolay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(94, 123);
            button2.Name = "button2";
            button2.Size = new Size(100, 25);
            button2.TabIndex = 1;
            button2.Text = "Orta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(94, 154);
            button3.Name = "button3";
            button3.Size = new Size(100, 25);
            button3.TabIndex = 2;
            button3.Text = "Zor";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(243, 57);
            label1.TabIndex = 3;
            label1.Text = "Mayın Tarlası";
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(94, 201);
            button4.Name = "button4";
            button4.Size = new Size(100, 25);
            button4.TabIndex = 4;
            button4.Text = "Nasıl Oynanır ? ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Firebrick;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(239, 258);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 5;
            button5.Text = "❌";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(281, 300);
            ControlBox = false;
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
    }
}
