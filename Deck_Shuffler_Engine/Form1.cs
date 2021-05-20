using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deck_Shuffler_Engine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DeckName_help.Text = "지정한 경로안에 덱 이름으로 된 폴더가 생성 됩니다." + Environment.NewLine + "같은 이름일 경우 이미있는 덱 안에 프로젝트가 생성됩니다.";
            Project_Open.FlatAppearance.BorderColor = Color.Black;
            Project_ST.FlatAppearance.BorderColor = Color.Black;
            PathF_b.FlatAppearance.BorderColor = Color.Black;
            Exit.FlatAppearance.BorderSize = 0;
            Plan_B = 0;
        }

        public static string Main_Path { get; set; }
        public static string Deck_N { get; set; }

        public static int Plan_B { get; set; }
        public static string Path_INI { get; set; }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
            this.Close();
        }

        private void PathF_b_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            PathF_T.Text = dialog.SelectedPath;    //선택한 다이얼로그 경로 저장
        }

        private void Project_ST_Click(object sender, EventArgs e)
        {
            if (PathF_T.Text == string.Empty || PathF_T.Text == "" || Deck_T.Text == string.Empty || Deck_T.Text == "")
            {
                MessageBox.Show("덱 생성 경로 또는 덱 이름이 구성되지않았습니다.");
            }

            else
            {
                if (!Directory.Exists(PathF_T.Text + "\\" + Deck_T.Text))
                {
                    Directory.CreateDirectory(PathF_T.Text + "\\" + Deck_T.Text);
                }
                
                if(!Directory.Exists(PathF_T.Text + "\\" + Deck_T.Text + "\\setting"))
                {
                    Directory.CreateDirectory(PathF_T.Text + "\\" + Deck_T.Text + "\\setting");
                }
                
                if(!Directory.Exists(PathF_T.Text + "\\" + Deck_T.Text + "\\img"))
                {
                    Directory.CreateDirectory(PathF_T.Text + "\\" + Deck_T.Text + "\\img");
                }
                
                Main_Path = PathF_T.Text + "\\" + Deck_T.Text;
                Deck_N = Deck_T.Text;

                Plan_B = 0;

                Form2 MyForm = new Form2();
                MyForm.Show();
            }
        }
        public string filepath;
        private void Project_Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "ini files (*.ini)|*.ini";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                Path_INI = filepath;
                Plan_B = 1;

                Form2 MyForm = new Form2();
                MyForm.Show();
            }
        }
    }
}
