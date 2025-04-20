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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = SystemColors.MenuBar;
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.ForeColor = SystemColors.MenuText;
            usernameTextBox.Location = new Point(42, 169);
            usernameTextBox.Margin = new Padding(4, 5, 4, 5);
            usernameTextBox.MaxLength = 25;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(275, 42);
            usernameTextBox.TabIndex = 0;
            // 
            // addtolistButton
            // 
            addtolistButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addtolistButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addtolistButton.Location = new Point(356, 173);
            addtolistButton.Margin = new Padding(4, 5, 4, 5);
            addtolistButton.Name = "addtolistButton";
            addtolistButton.Size = new Size(147, 33);
            addtolistButton.TabIndex = 1;
            addtolistButton.Text = "add to list";
            addtolistButton.UseVisualStyleBackColor = true;
            addtolistButton.Click += addtolist;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ButtonFace;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(44, 235);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(458, 501);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(220, 745);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(96, 35);
            button2.TabIndex = 4;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Remove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 63);
            label1.TabIndex = 5;
            label1.Text = "ABSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 38);
            label2.TabIndex = 6;
            label2.Text = "To Do List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Firebrick;
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
    }
}
