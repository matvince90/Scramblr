using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Scramblr
{
    public partial class Scramblr : Form
    {
        int editNum;
        List<Question> questions = new List<Question>();
        public Scramblr()
        {
            InitializeComponent();
        }

        private void addQ_Click(object sender, EventArgs e)
        {
            if (addQ.Text == "Add")
            {
                if (qBox.Text != "")
                {
                    string a3Text = null, a4Text = null, a5Text = null;
                    if (cb5.Checked == true)
                        a5Text = a5.Text;
                    if (cb4.Checked == true)
                        a4Text = a4.Text;
                    if (cb3.Checked == true)
                        a3Text = a3.Text;
                    questions.Add(new Question(qBox.Text, a1.Text, a2.Text, a3Text, a4Text, a5Text));
                    qList.Items.Add(qBox.Text.Substring(0, 5) + "...");
                    qBox.Text = a1.Text = a2.Text = a3.Text = a4.Text = a5.Text = "";
                    cb3.Checked = cb4.Checked = cb5.Checked = false;

                }
            }
            else
            {
                if (qBox.Text != "")
                {
                    string a3Text = null, a4Text = null, a5Text = null;
                    if (cb5.Checked == true)
                        a5Text = a5.Text;
                    if (cb4.Checked == true)
                        a4Text = a4.Text;
                    if (cb3.Checked == true)
                        a3Text = a3.Text;
                    questions[editNum] = new Question(qBox.Text, a1.Text, a2.Text, a3Text, a4Text, a5Text);
                    qList.Items[editNum] = (qBox.Text.Substring(0, 5) + "...");
                    qBox.Text = a1.Text = a2.Text = a3.Text = a4.Text = a5.Text = "";
                    addQ.Text = "Add";
                    remQ.Enabled = generate.Enabled = true;
                    cb3.Checked = cb4.Checked = cb5.Checked = false;
                }
            }
        }

        private void remQ_Click(object sender, EventArgs e)
        {
            questions.RemoveAt(qList.SelectedIndex);
            qList.Items.Remove(qList.SelectedItem);
        }

        private void generate_Click(object sender, EventArgs e)
        {
            string test = "";
            Random r = new Random();
            List<Question> qCopy = new List<Question> (questions);
            int i = 1;
            while (qCopy.Count > 1)
            {
                int rand = r.Next(0, qCopy.Count);
                Question q = qCopy.ElementAt(rand);
                test += i++ + ". " + q.getQuestion();
                test += "\n\tA. " + q.getA1();
                test += "\n\tB. " + q.getA2();
                if (q.getA3() != null)
                    test += "\n\tC. " + q.getA3();
                if (q.getA4() != null)
                    test += "\n\tD. " + q.getA4();
                if (q.getA5() != null)
                    test += "\n\tE. " + q.getA5();
                test += "\n\n";
                qCopy.RemoveAt(rand);
            }
            if (qCopy.Count == 1)
            {
                Question q = qCopy.ElementAt(0);
                test += i++ + ". " + q.getQuestion();
                test += "\n\tA. " + q.getA1();
                test += "\n\tB. " + q.getA2();
                if (q.getA3() != null)
                    test += "\n\tC. " + q.getA3();
                if (q.getA4() != null)
                    test += "\n\tD. " + q.getA4();
                if (q.getA5() != null)
                    test += "\n\tE. " + q.getA5();
                test += "\n\n";
                test += "\n\n";
                qCopy.RemoveAt(0);
            }
            Viewer viewer = new Viewer();
            viewer.setText(test);
            viewer.ShowDialog();
        }

        private void editQ_Click(object sender, EventArgs e)
        {
            editNum = qList.SelectedIndex;
            Question edit = questions.ElementAt(editNum);
            qBox.Text = edit.getQuestion();
            a1.Text = edit.getA1();
            a2.Text = edit.getA2();
            if (edit.getA3() != null)
            {
                cb3.Checked = true;
                a3.Text = edit.getA3();
            }
            if (edit.getA4() != null)
            {
                cb4.Checked = true;
                a4.Text = edit.getA4();
            }
            if (edit.getA5() != null)
            {
                cb5.Checked = true;
                a5.Text = edit.getA5();
            }
            remQ.Enabled = generate.Enabled = false;
            addQ.Text = "Done";
        }

        private void qList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (qList.SelectedIndex > -1)
                editQ.Enabled = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cb3.Checked == true)
                a3.Enabled = cb4.Visible = a4.Visible = true;
            else
                a3.Enabled = cb4.Visible = a4.Visible = cb5.Visible = a5.Visible = a5.Enabled = cb4.Checked = cb5.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb4.Checked == true)
                a4.Enabled = cb5.Visible = a5.Visible = true;
            else
                a4.Enabled = cb5.Visible = a5.Visible = cb5.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb5.Checked == true)
                a5.Enabled = true;
            else
                a5.Enabled = cb5.Visible = false;
        }

        private void qBox_TextChanged(object sender, EventArgs e)
        {
            if (qBox.Text.Equals("") || a1.Text.Equals("") || a2.Text.Equals(""))
                addQ.Enabled = false;
            else
                addQ.Enabled = true;
        }

        private void a1_TextChanged(object sender, EventArgs e)
        {
            if (qBox.Text.Equals("") || a1.Text.Equals("") || a2.Text.Equals(""))
                addQ.Enabled = false;
            else
                addQ.Enabled = true;
        }

        private void a2_TextChanged(object sender, EventArgs e)
        {
            if (qBox.Text.Equals("") || a1.Text.Equals("") || a2.Text.Equals(""))
                addQ.Enabled = false;
            else
                addQ.Enabled = true;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questions.Clear();
            qList.Items.Clear();
            qBox.Text = a1.Text = a2.Text = a3.Text = a4.Text = a5.Text = "";
            cb3.Checked = cb4.Checked = cb5.Checked = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (Question q in questions)
            {
                txt += "**" + q.getQuestion();
                txt += "~~" + q.getA1();
                txt += "~~" + q.getA2();
                if (q.getA3() != null)
                    txt += "~~" + q.getA3();
                if (q.getA4() != null)
                    txt += "~~" + q.getA4();
                if (q.getA5() != null)
                    txt += "~~" + q.getA5();
                txt += "~~";
            }
            txt += "**";
            saveDialog.ShowDialog();
            if (saveDialog.FileName != "") 
                System.IO.File.WriteAllText(@saveDialog.FileName, txt);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.ShowDialog();
            questions.Clear();
            string test;
            string q, a1, a2, a3 = null, a4 = null, a5 = null;
            test = System.IO.File.ReadAllText(@openDialog.FileName);
            while (!test.Equals("**"))
            {
                q = test.Substring(2, test.IndexOf("~~"));
                test = test.Substring(test.IndexOf("~~") + 2);
                a1 = test.Substring(2, test.IndexOf("~~"));
                test = test.Substring(test.IndexOf("~~") + 2);
                a2 = test.Substring(2, test.IndexOf("~~"));
                test = test.Substring(test.IndexOf("~~") + 2);
                if (!test.Substring(0, 4).Equals("**"))
                {
                    a3 = test.Substring(2, test.IndexOf("~~"));
                    test = test.Substring(test.IndexOf("~~") + 2);

                    if (!test.Substring(0, 4).Equals("**"))
                    {
                        a4 = test.Substring(2, test.IndexOf("~~"));
                        test = test.Substring(test.IndexOf("~~") + 2);

                        if (!test.Substring(0, 4).Equals("**"))
                        {
                            a5 = test.Substring(2, test.IndexOf("~~"));
                            test = test.Substring(test.IndexOf("~~") + 2);
                        }
                    }
                }
                Question question = new Question(q, a1, a2, a3, a4, a5);
            }
        }

    }
}
