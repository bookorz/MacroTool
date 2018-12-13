using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroTool
{
    public partial class Form1 : Form
    {
        protected Point MousePt;  // 紀錄移動前和移動後的滑鼠座標
        protected bool canMove = false;         // 紀錄表單可否被拖曳
        protected int LeftVar = 0, TopVar = 0;  // 紀錄form的移動量
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 拖曳form
            if (canMove)
            {
                this.Left += e.X - MousePt.X;
                this.Top += e.Y - MousePt.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // 設定滑鼠移動前的座標
            MousePt = new Point(e.X, e.Y);
            canMove = true;  // 如果按下滑鼠左鍵時 可以移動表單
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            canMove = false;  // 如果放開滑鼠左鍵時 暫停移動表單
        }

        class Command
        {
            public string EachCommand { get; set; }
        }

        private void Load_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1;
            StreamReader myStream = null;
            List<Command> cmds = new List<Command>();
            try
            {
                openFileDialog1 = new OpenFileDialog();
                //openFileDialog1.Filter = "json files (*.json)|*.json";
                //openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string line = string.Empty;
                    string[] info = ShowInfoDialog();
                    string macroName = info[0];
                    string index = info[1];
                    using (myStream = new StreamReader(openFileDialog1.FileName))
                    {
                        fileName_lb.Text = openFileDialog1.FileName;
                        while ((line = myStream.ReadLine()) != null)
                        {
                            Command tmp = new Command();
                            tmp.EachCommand = line.Replace("/", "").Trim();
                            if (tmp.EachCommand.IndexOf("'") != -1)
                            {
                                tmp.EachCommand = tmp.EachCommand.Substring(0, tmp.EachCommand.IndexOf("'")).Trim();
                            }
                            if (!tmp.EachCommand.Equals(""))
                            {
                                cmds.Add(tmp);
                                if (textBox2.Text.Equals(""))
                                {
                                    textBox2.Text = "/";
                                }
                                textBox2.Text += tmp.EachCommand + "/";
                            }
                        }

                    }

                    dataGridView1.DataSource = cmds;
                    textBox1.Text = "SET:MNAME:M,"+ index + ","+ macroName;
                    textBox2.Text = "SET:MEDIT:M,"+ macroName + "," + textBox2.Text;
                    textBox3.Text = "SET:MSAVE";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void Copy1_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Copy to clipboard");
        }

        private void Copy2_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
            MessageBox.Show("Copy to clipboard");
        }

        private void Copy3_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
            MessageBox.Show("Copy to clipboard");
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string[] ShowInfoDialog()
        {
            string[] result = new string[] { "", "" };
            Form prompt = new Form()
            {
                Width = 450,
                Height = 280,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Macro info",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label lblUser = new Label() { Left = 30, Top = 20, Text = "Name", Width = 200 };
            TextBox tbUser = new TextBox() { Left = 30, Top = 50, Width = 350, Text = "" };
            Label lblPassword = new Label() { Left = 30, Top = 90, Text = "Index", Width = 200 };
            TextBox tbPassword = new TextBox() { Left = 30, Top = 120, Width = 350 };
            //tbPassword.PasswordChar = '';
            Button confirmation = new Button() { Text = "Ok", Left = 280, Width = 100, Top = 170, DialogResult = DialogResult.OK, Height = 35 };
            lblUser.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPassword.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tbUser.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tbPassword.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            confirmation.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(lblUser);
            prompt.Controls.Add(tbUser);
            prompt.Controls.Add(tbPassword);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(lblPassword);
            prompt.AcceptButton = confirmation;
            tbPassword.Focus();
            //tbUser.Enabled = false;

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                result[0] = tbUser.Text;
                result[1] = tbPassword.Text;
            }
            return result;
        }
    }
}
