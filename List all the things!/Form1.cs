using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_all_the_things_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();

        Random random = new Random();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            list.Add(textBoxAdd.Text);
            textBoxAdd.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                list.Clear();
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                MessageBox.Show("Count: " + list.Count.ToString());
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                MessageBox.Show("First: " + list[0].ToString());
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                MessageBox.Show("Last: " + list[list.Count - 1].ToString());
            }

            richTextBox.Text = "";
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                MessageBox.Show(list[random.Next(list.Count - 1)] + "!");
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                for (int listindex = 0; listindex < list.Count; listindex++)
                {
                    richTextBox.Text += list[listindex] + " ";
                }
            }
        }

        private void buttonUpper_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";

            if (list.Count != 0)
            {
                for (int listindex = 0; listindex < list.Count; listindex++)
                {
                    richTextBox.Text += list[listindex].ToUpper();
                }
            }
        }

        private void buttonContains_Click(object sender, EventArgs e)
        {
            if (list.Count != 0)
            {
                int containedText = 0;

                for (int listindex = 0; listindex < list.Count; listindex++)
                {
                    if (list[listindex] == textBoxContains.Text)
                    {
                        containedText++;
                    }
                }

                if (containedText == 0)
                {
                    MessageBox.Show("The list does not contain " + textBoxContains.Text + "!");
                }
                else
                {
                    MessageBox.Show("The list contains " + containedText.ToString() + " " + textBoxContains.Text + "!");
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";

            list.Sort();

            if (list.Count != 0)
            {
                for (int listindex = 0; listindex < list.Count; listindex++)
                {
                    richTextBox.Text += list[listindex] + " ";
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (textBoxRemove.Text != "")
            {
                richTextBox.Text = "";

                if (list.Count != 0)
                {
                    int indexToRemove = 0;
                    int.TryParse(textBoxRemove.Text, out indexToRemove);

                    for (int listindex = 0; listindex < list.Count; listindex++)
                    {
                        if (listindex == indexToRemove)
                        {
                            list.RemoveAt(listindex);
                        }
                    }

                    for (int listindex = 0; listindex < list.Count; listindex++)
                    {
                        richTextBox.Text += list[listindex] + " ";
                    }
                }
            }
        }
    }
}
