namespace WinFormsApp1
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

        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            addtolistButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.White;
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Font = new Font("Comfortaa", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.ForeColor = SystemColors.MenuText;
            usernameTextBox.Location = new Point(42, 169);
            usernameTextBox.Margin = new Padding(4, 5, 4, 5);
            usernameTextBox.MaxLength = 28;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(274, 36);
            usernameTextBox.TabIndex = 0;
            // 
            // addtolistButton
            // 
            addtolistButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addtolistButton.BackColor = Color.FromArgb(38, 166, 154);
            addtolistButton.Font = new Font("Comfortaa", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addtolistButton.ForeColor = Color.White;
            addtolistButton.Location = new Point(356, 166);
            addtolistButton.Margin = new Padding(4, 5, 4, 5);
            addtolistButton.Name = "addtolistButton";
            addtolistButton.Size = new Size(147, 40);
            addtolistButton.TabIndex = 1;
            addtolistButton.Text = "add to list";
            addtolistButton.UseVisualStyleBackColor = false;
            addtolistButton.Click += addtolist;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(250, 250, 250);
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(44, 235);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(458, 501);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(38, 166, 154);
            button1.Font = new Font("Comfortaa", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 0;
            button1.Text = "Select All";
            button1.UseVisualStyleBackColor = false;
            button1.Click += SelectAll;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(38, 166, 154);
            button3.Font = new Font("Comfortaa", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(128, 3);
            button3.Name = "button3";
            button3.Size = new Size(131, 42);
            button3.TabIndex = 1;
            button3.Text = "Deselect All";
            button3.UseVisualStyleBackColor = false;
            button3.Click += DeselectAll;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.BackColor = Color.LightCoral;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(224, 745);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(96, 35);
            button2.TabIndex = 4;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Remove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(38, 50, 56);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(182, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 86);
            label1.TabIndex = 5;
            label1.Text = "ABSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 52);
            label2.TabIndex = 6;
            label2.Text = "To Do List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 229, 180);
            ClientSize = new Size(536, 797);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(addtolistButton);
            Controls.Add(usernameTextBox);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "To-Do List";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private Button addtolistButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button3;
    }
}
