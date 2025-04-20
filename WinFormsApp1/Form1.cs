using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using System.IO;
using System.Collections;
using System.Linq;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Label> labelDictionary;
        private Dictionary<CheckBox, Panel> panelDictionary;
        int num;
        const string path = "C:\\Users\\Aris\\source\\repos\\WinFormsApp1\\TDL list.txt";



        int check;
        public Form1()
        {
            InitializeComponent();
            labelDictionary = new Dictionary<string, Label>();
            panelDictionary = new Dictionary<CheckBox, Panel>();
            num = 0;
            CheckSave();

        }
        private void CheckSave()
        {
            List<string> list = new List<string>();
            list = File.ReadAllLines(path).ToList();

            foreach (string item in list)
            {
                flowLayoutPanel1.Controls.Add(CreatePanel(item));
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (labelDictionary[i.ToString()].Text.EndsWith(" "))
                {
                    labelDictionary[i.ToString()].Font = new Font("Segoe UI", 15.75F, FontStyle.Strikeout);
                }
            }

        }

        private void addtolist(object sender, EventArgs e)
        {

            if (usernameTextBox.Text != "")
            {
                flowLayoutPanel1.Controls.Add(CreatePanel(usernameTextBox.Text));
                usernameTextBox.Clear();


                List<string> list = new List<string>();
                foreach (var values in labelDictionary.Values)
                {
                    list.Add(values.Text);
                }

                File.WriteAllLines(path, list);
            }
        }


        private void Remove(object sender, EventArgs e)
        {

            foreach (var checkBox in panelDictionary.Keys)
            {
                if (checkBox.Checked)
                {
                    panelDictionary.Remove(checkBox);
                    flowLayoutPanel1.Controls.Clear();

                    foreach (var checkBox1 in panelDictionary.Keys)
                    {
                        flowLayoutPanel1.Controls.Add(panelDictionary[checkBox1]);
                    }

                    foreach (var keys in labelDictionary.Keys)
                    {
                        if (keys.Equals(checkBox.Name))
                        {
                            labelDictionary.Remove(keys.ToString());
                        }
                    }

                    List<string> list = new List<string>();
                    foreach (var values in labelDictionary.Values)
                    {
                        list.Add(values.Text);
                    }

                    File.WriteAllLines(path, list);
                }

            }

        }

        private Panel CreatePanel(string text)
        {
            string? name = null;
            name += num.ToString();

            CheckBox checkBox1 = new CheckBox();
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(5, 27);
            checkBox1.Name = name;
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = true;


            Label usernameLabel1 = new Label();
            usernameLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular);
            usernameLabel1.AutoSize = true;
            usernameLabel1.Location = new Point(25, 10);
            usernameLabel1.Name = name;
            usernameLabel1.Size = new Size(3, 3);
            usernameLabel1.TabIndex = 2;
            usernameLabel1.Text = text;

            Button button1 = new Button();
            button1.Location = new Point(350, 19);
            button1.Name = name;
            button1.Size = new Size(83, 31);
            button1.TabIndex = 3;
            button1.Text = "done";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Done;

            Panel panel = new Panel();
            panel.Controls.Add(button1);
            panel.Controls.Add(usernameLabel1);
            panel.Controls.Add(checkBox1);
            panel.Location = new Point(3, 3);
            panel.Name = name;
            panel.Size = new Size(490, 60);
            panel.TabIndex = 0;
            panel.Visible = true;


            labelDictionary[name] = usernameLabel1;
            panelDictionary[checkBox1] = panel;
            num++;


            return panel;
        }
        private void Done(object sender, EventArgs e)
        {
            Button button = sender as Button;


            if (labelDictionary[button.Name].Font.Strikeout == false)
            {
                labelDictionary[button.Name].Font = new Font("Segoe UI", 15.75F, FontStyle.Strikeout);

                foreach (var key in labelDictionary.Keys)
                {
                    if (key.Equals(button.Name))
                    {
                        labelDictionary[key].Text += " ";
                    }

                    List<string> list = new List<string>();
                    foreach (var values in labelDictionary.Values)
                    {
                        list.Add(values.Text);
                    }

                    File.WriteAllLines(path, list);
                }
            }
            else
            {
                labelDictionary[button.Name].Font = new Font("Segoe UI", 15.75F, FontStyle.Regular);

                foreach (var key in labelDictionary.Keys)
                {
                    if (key.Equals(button.Name))
                    {
                        labelDictionary[key].Text = labelDictionary[key].Text.Substring(0, labelDictionary[key].Text.Length - 1);
                    }

                    List<string> list = new List<string>();
                    foreach (var values in labelDictionary.Values)
                    {
                        list.Add(values.Text);
                    }

                    File.WriteAllLines(path, list);
                }
            }
        }
    }
}
