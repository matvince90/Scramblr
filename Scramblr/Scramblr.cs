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
        const string SPACER = "~~";
        string savePath;
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
                editQ.Enabled = remQ.Enabled = true;
            else
                editQ.Enabled = remQ.Enabled = false;
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
            addQ.Text = "Add";
            editQ.Enabled = remQ.Enabled = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (Question q in questions)
            {
                txt += "*" + q.getQuestion();
                txt += SPACER + q.getA1();
                txt += SPACER + q.getA2();
                if (q.getA3() != null)
                    txt += SPACER + q.getA3();
                if (q.getA4() != null)
                    txt += SPACER + q.getA4();
                if (q.getA5() != null)
                    txt += SPACER + q.getA5();
                txt += SPACER;
            }
            txt += "**";
            if (savePath == null)
            {
                saveDialog.ShowDialog();
                if (saveDialog.FileName != "")
                {
                    savePath = saveDialog.FileName;
                    System.IO.File.WriteAllText(@savePath, txt);
                    this.Text = "Scramblr - " + savePath;
                }
            }
            else
            {
                System.IO.File.WriteAllText(@savePath, txt);
            }
        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.ShowDialog();
            if (!openDialog.FileName.Equals(""))
            {
                string test = System.IO.File.ReadAllText(@openDialog.FileName);
                questions.Clear();
                qList.Items.Clear(); 
                qBox.Text = a1.Text = a2.Text = a3.Text = a4.Text = a5.Text = "";
                cb3.Checked = cb4.Checked = cb5.Checked = false;
                addQ.Text = "Add";
                editQ.Enabled = remQ.Enabled = false;
                savePath = openDialog.FileName;
                this.Text = "Scramblr - " + savePath;

                while (!test.Equals("**"))
                {
                    string q, A1, A2, A3 = null, A4 = null, A5 = null;
                    q = test.Substring(1, test.IndexOf(SPACER)-1);
                    test = test.Substring(test.IndexOf(SPACER) + SPACER.Length);
                    A1 = test.Substring(0, test.IndexOf(SPACER));
                    test = test.Substring(test.IndexOf(SPACER) + SPACER.Length);
                    A2 = test.Substring(0, test.IndexOf(SPACER));
                    test = test.Substring(test.IndexOf(SPACER) + SPACER.Length);
                    if (!test.Substring(0, 1).Equals("*"))
                    {
                        A3 = test.Substring(0, test.IndexOf(SPACER));
                        test = test.Substring(test.IndexOf(SPACER) + SPACER.Length);

                        if (!test.Substring(0, 1).Equals("*"))
                        {
                            A4 = test.Substring(0, test.IndexOf(SPACER));
                            test = test.Substring(test.IndexOf(SPACER) + SPACER.Length);

                            if (!test.Substring(0, 1).Equals("*"))
                            {
                                A5 = test.Substring(0, test.IndexOf(SPACER));
                                test = test.Substring(test.IndexOf(SPACER) + SPACER.Length);
                            }
                        }
                    }
                    Question question = new Question(q, A1, A2, A3, A4, A5);
                    questions.Add(question);
                    qList.Items.Add(q.Substring(0, 5) + "...");

                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savePath = null;
            this.Text = "Scramblr";
            questions.Clear();
            qList.Items.Clear();
            qBox.Text = a1.Text = a2.Text = a3.Text = a4.Text = a5.Text = "";
            cb3.Checked = cb4.Checked = cb5.Checked = false;
            addQ.Text = "Add";
            editQ.Enabled = remQ.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (Question q in questions)
            {
                txt += "*" + q.getQuestion();
                txt += SPACER + q.getA1();
                txt += SPACER + q.getA2();
                if (q.getA3() != null)
                    txt += SPACER + q.getA3();
                if (q.getA4() != null)
                    txt += SPACER + q.getA4();
                if (q.getA5() != null)
                    txt += SPACER + q.getA5();
                txt += SPACER;
            }
            txt += "**";
            saveDialog.ShowDialog();
            if (saveDialog.FileName != "")
            {
                savePath = saveDialog.FileName;
                System.IO.File.WriteAllText(@savePath, txt);
                this.Text = "Scramblr - " + savePath;
            }
        }

    }
}