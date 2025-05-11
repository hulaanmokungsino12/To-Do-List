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
        //mainly used sa almost lahat ng code
        private Dictionary<string, Label> labelDictionary;

        //created mainly for deleting purpose for view to users
        private Dictionary<CheckBox, Panel> panelDictionary;

        int num;
        const string path = "C:\\Users\\Aris\\source\\repos\\To Do List PT\\TDL list.txt";


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
                    labelDictionary[i.ToString()].Font = new Font("Comfortaa", 10F, FontStyle.Strikeout);
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
                    //para maremove sa view ng user
                    panelDictionary.Remove(checkBox);
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(button1);
                    flowLayoutPanel1.Controls.Add(button3);


                    foreach (var checkBox1 in panelDictionary.Keys)
                    {
                        flowLayoutPanel1.Controls.Add(panelDictionary[checkBox1]);
                    }
                    //
                    foreach (var key in labelDictionary.Keys)
                    {
                        if (key.Equals(checkBox.Name))
                        {
                            labelDictionary.Remove(key.ToString());
                        }
                    }

                    //para to sa checksave
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
            checkBox1.Location = new Point(5, 26);
            checkBox1.Name = name;
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 0;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = true;


            Label usernameLabel1 = new Label();
            usernameLabel1.Font = new Font("Comfortaa", 10F, FontStyle.Regular);
            usernameLabel1.AutoSize = true;
            usernameLabel1.Location = new Point(25, 19);
            usernameLabel1.Name = name;
            usernameLabel1.Size = new Size(3, 3);
            usernameLabel1.TabIndex = 2;
            usernameLabel1.Text = text;

            Button DoneButton = new Button();
            DoneButton.Location = new Point(350, 18);
            DoneButton.Name = name;
            DoneButton.Size = new Size(83, 35);
            DoneButton.TabIndex = 3;
            DoneButton.BackColor = Color.FromArgb(38, 139, 87);
            DoneButton.ForeColor = Color.White;
            DoneButton.Text = "done";
            DoneButton.UseVisualStyleBackColor = false;
            DoneButton.Click += Done;

            Panel panel = new Panel();
            panel.Controls.Add(DoneButton);
            panel.Controls.Add(usernameLabel1);
            panel.Controls.Add(checkBox1);
            panel.Location = new Point(3, 3);
            panel.Name = name;
            panel.Size = new Size(440, 60);
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
                labelDictionary[button.Name].Font = new Font("Comfortaa", 10F, FontStyle.Strikeout);

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
                labelDictionary[button.Name].Font = new Font("Comfortaa", 10F, FontStyle.Regular);

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

        private void SelectAll(object sender, EventArgs e)
        {
            foreach (var CheckBox1 in panelDictionary.Keys)
            {
                CheckBox1.Checked = true;
            }
        }
        private void DeselectAll(object sender, EventArgs e)
        {
            foreach (var checkbox in panelDictionary.Keys)
            {
                checkbox.Checked = false;
            }
        }
    }
}
//Group 4 To Do List
//Albano, Johnmharc | Bautista, Aris | Sablaon, Andrei | Villacorte, Alexchristian