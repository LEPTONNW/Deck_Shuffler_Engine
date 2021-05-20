using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Deck_Shuffler_Engine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Point MouseDownLocation;
        public string M_Path = Form1.Main_Path; //Form1로 부터 받은 지정된 경로 
        public string Deck_Name = "";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        //앞
        public string F2_Width = "";
        public string F2_Height = "";
        public string F2 = "";
        public string LA_X = "";
        public string LA_Y = "";
        public string LA_SIZE = "";
        public string LA_FONT = "";
        public string LA_COLOR = "";
        public string LA_FAM = "";

        //뒤
        public string F2_1_Width = "";
        public string F2_1_Height = "";
        public string F2_1 = "";
        public string LA2_X = "";
        public string LA2_Y = "";
        public string LA2_SIZE = "";
        public string LA2_FONT = "";
        public string LA2_COLOR = "";

        public string LA2_FAM = ""; //임시로생성


        public string MainText = "";
        public string MainText_B = "";

        public int SV_CO = 0; //저장 했는지 확인변수

        public string temp = "";
        public string Path_P = "";
        public int Path_C = 0;
        public int T_Count = 0;

        public string IMG_NAME = "";
        public string IMG_NAME_B = "";
        public int F_B = 0;

        public Bitmap MyImage1;
        public Bitmap MyImage2;


        private void Form2_Load(object sender, EventArgs e)
        {
            T_option_b.FlatAppearance.BorderSize = 0;
            New_w.FlatAppearance.BorderSize = 0;
            help.FlatAppearance.BorderSize = 0;
            back_btn.FlatAppearance.BorderSize = 0;
            
            if (Form1.Plan_B == 1)
            {
                try
                {
                    title_T.Text = Path.GetFileName(Form1.Path_INI).Replace(".ini", "");
                    title_T.Enabled = false;
                    New_w.Hide();

                    //앞
                    StringBuilder Ptext1 = new StringBuilder();
                    int ret1 = GetPrivateProfileString("Front1", "FRONT_T", "", Ptext1, 2147483647, Form1.Path_INI);
                    MainText = Ptext1.ToString();

                    StringBuilder Ptext2 = new StringBuilder();
                    int ret2 = GetPrivateProfileString("Front2", "IMG_NAME", "", Ptext2, 2147483647, Form1.Path_INI);
                    IMG_NAME = Ptext2.ToString();

                    StringBuilder Ptext3 = new StringBuilder();
                    int ret3 = GetPrivateProfileString("Front3", "F2_SIZE", "", Ptext3, 2147483647, Form1.Path_INI);
                    string[] temp1 = Ptext3.ToString().Split(',');
                    string[] temp1_1 = temp1[0].Split('=');
                    string[] temp1_2 = temp1[1].Split('=');
                    F2_Width = temp1_1[1];
                    F2_Height = temp1_2[1].Replace("}", "");


                    StringBuilder Ptext4 = new StringBuilder();
                    int ret4 = GetPrivateProfileString("Front4", "LA_FONT", "", Ptext4, 2147483647, Form1.Path_INI);
                    string[] temp2 = Ptext4.ToString().Split(',');
                    LA_X = temp2[0];
                    LA_Y = temp2[1];
                    LA_SIZE = temp2[2];
                    LA_FONT = temp2[3];
                    LA_FAM = temp2[4];
                    LA_COLOR = temp2[5];

                    //뒤
                    //WritePrivateProfileString("Back1", "Back_T", MainText_B, M_Path);
                    //WritePrivateProfileString("Back2", "IMG_NAME_B", IMG_NAME_B, M_Path);
                    //WritePrivateProfileString("Back3", "F2_B_SIZE", F2_1_Width + "," + F2_1_Height, M_Path);
                    //WritePrivateProfileString("Back4", "LA2_FONT", LA2_X + "," + LA2_Y + "," + LA2_SIZE + "," + LA2_FONT + "," + LA2_COLOR, M_Path);

                    StringBuilder Ptext5 = new StringBuilder();
                    int ret5 = GetPrivateProfileString("Back1", "Back_T", "", Ptext5, 2147483647, Form1.Path_INI);
                    MainText_B = Ptext5.ToString();

                    StringBuilder Ptext6 = new StringBuilder();
                    int ret6 = GetPrivateProfileString("Back2", "IMG_NAME_B", "", Ptext6, 2147483647, Form1.Path_INI);
                    IMG_NAME_B = Ptext6.ToString();

                    StringBuilder Ptext7 = new StringBuilder();
                    int ret7 = GetPrivateProfileString("Back3", "F2_B_SIZE", "", Ptext7, 2147483647, Form1.Path_INI);
                    string[] temp1_B = Ptext7.ToString().Split(',');
                    string[] temp1_1_B = temp1_B[0].Split('=');
                    string[] temp1_2_B = temp1_B[1].Split('=');
                    F2_1_Width = temp1_1_B[1];
                    F2_1_Height = temp1_2_B[1].Replace("}", "");


                    StringBuilder Ptext8 = new StringBuilder();
                    int ret8 = GetPrivateProfileString("Back4", "LA2_FONT", "", Ptext8, 2147483647, Form1.Path_INI);
                    string[] temp2_B = Ptext8.ToString().Split(',');
                    LA2_X = temp2_B[0];
                    LA2_Y = temp2_B[1];
                    LA2_SIZE = temp2_B[2];
                    LA2_FONT = temp2_B[3];
                    LA2_COLOR = temp2_B[4];


                    //창크기 재설정
                    this.Size = new Size(Convert.ToInt32(F2_Width), Convert.ToInt32(F2_Height));

                    //이미지 재설정
                    string fileName = Path.GetFileName(Form1.Path_INI);
                    MyImage1 = new Bitmap(Form1.Path_INI.Replace("setting\\" + fileName, "img\\" + IMG_NAME));
                    MyImage2 = new Bitmap(Form1.Path_INI.Replace("setting\\" + fileName, "img\\" + IMG_NAME_B));
                    pictureBox1.Image = (Image)MyImage1;
                    Path_C = 1;

                    //텍스트 재설정
                    Main_T.Text = MainText;

                    //폰트 재설정
                    Main_T.Font = new Font(LA_FONT, Convert.ToInt32(LA_SIZE), FontStyle.Regular);
                    Main_T.ForeColor = Color.FromArgb(Convert.ToInt32(LA_COLOR));
                    Main_T.Left = Convert.ToInt32(LA_X);
                    Main_T.Top = Convert.ToInt32(LA_Y);
                    //Main_T.Text = MainText;

                    Main_T.BackColor = Color.Transparent;
                    Main_T.Parent = pictureBox1;
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
            else
            {
                MainText = Main_T.Text;
                //첫 생성
                LA_X = Main_T.Location.X.ToString(); //텍스트 X좌표
                LA_Y = Main_T.Location.Y.ToString(); //텍스트 Y좌표
                LA_SIZE = Main_T.Font.Size.ToString(); //텍스트 사이즈
                LA_FONT = Main_T.Font.Name.ToString(); //텍스트 폰트
                LA_COLOR = Main_T.ForeColor.ToArgb().ToString(); //텍스트 폰트 RGB컬러

                LA2_X = Main_T.Location.X.ToString(); //텍스트 X좌표
                LA2_Y = Main_T.Location.Y.ToString(); //텍스트 Y좌표
                LA2_SIZE = Main_T.Font.Size.ToString(); //텍스트 사이즈
                LA2_FONT = Main_T.Font.Name.ToString(); //텍스트 폰트
                LA2_COLOR = Main_T.ForeColor.ToArgb().ToString(); //텍스트 폰트 RGB컬러


                //X, Y, SIZE, FONT, COLOR순서로 함
            }
        }

        public void Save()
        {
            if (F_B_2 == 0)
            {
                Deck_Name = title_T.Text + ".ini";
                string[] temp = this.Size.ToString().Split(',');
                F2_Width = temp[0]; //폼X크기
                F2_Height = temp[1]; //폼Y크기
                LA_X = Main_T.Location.X.ToString(); //텍스트 X좌표
                LA_Y = Main_T.Location.Y.ToString(); //텍스트 Y좌표
                LA_SIZE = Math.Round(Convert.ToDouble(Main_T.Font.Size)).ToString(); //텍스트 사이즈
                LA_FONT = Main_T.Font.Name.ToString(); //텍스트 폰트
                LA_COLOR = Main_T.ForeColor.ToArgb().ToString(); //텍스트 폰트 RGB컬러
                LA_FAM = Main_T.Font.Style.ToString();
                F2 = this.Size.ToString();
            }
            else
            {
                Deck_Name = title_T.Text + ".ini";
                string[] temp = this.Size.ToString().Split(',');
                F2_1_Width = temp[0]; //폼X크기
                F2_1_Height = temp[1]; //폼Y크기
                LA2_X = Main_T.Location.X.ToString(); //텍스트 X좌표
                LA2_Y = Main_T.Location.Y.ToString(); //텍스트 Y좌표
                LA2_SIZE = Math.Round(Convert.ToDouble(Main_T.Font.Size)).ToString(); //텍스트 사이즈
                LA2_FONT = Main_T.Font.Name.ToString(); //텍스트 폰트
                LA2_COLOR = Main_T.ForeColor.ToArgb().ToString(); //텍스트 폰트 RGB컬러
                F2_1 = this.Size.ToString();
            }


            if (Form1.Plan_B == 1)
            {
                M_Path = Form1.Path_INI;
                WritePrivateProfileString("Front1", "FRONT_T", MainText, M_Path);
                WritePrivateProfileString("Front2", "IMG_NAME", IMG_NAME, M_Path);
                WritePrivateProfileString("Front3", "F2_SIZE", F2, M_Path);
                WritePrivateProfileString("Front4", "LA_FONT", LA_X + "," + LA_Y + "," + LA_SIZE + "," + LA_FONT + "," + LA_FAM + "," + LA_COLOR, M_Path);

                if (F_B == 1)
                {
                    WritePrivateProfileString("Back1", "Back_T", MainText_B, M_Path);
                    WritePrivateProfileString("Back2", "IMG_NAME_B", IMG_NAME_B, M_Path);
                    WritePrivateProfileString("Back3", "F2_B_SIZE", F2_1, M_Path);
                    WritePrivateProfileString("Back4", "LA2_FONT", LA2_X + "," + LA2_Y + "," + LA2_SIZE + "," + LA2_FONT + "," + LA2_COLOR, M_Path);
                }
                //X, Y, SIZE, FONT, COLOR순서로 함
            }
            else
            {
                WritePrivateProfileString("Front1", "FRONT_T", MainText, M_Path + "\\setting\\" + Deck_Name);
                WritePrivateProfileString("Front2", "IMG_NAME", IMG_NAME, M_Path + "\\setting\\" + Deck_Name);
                WritePrivateProfileString("Front3", "F2_SIZE", F2, M_Path + "\\setting\\" + Deck_Name);
                WritePrivateProfileString("Front4", "LA_FONT", LA_X + "," + LA_Y + "," + LA_SIZE + "," + LA_FONT + "," + LA_FAM + "," + LA_COLOR, M_Path + "\\setting\\" + Deck_Name);

                if (F_B == 1)
                {
                    WritePrivateProfileString("Back1", "Back_T", MainText_B, M_Path + "\\setting\\" + Deck_Name);
                    WritePrivateProfileString("Back2", "IMG_NAME_B", IMG_NAME_B, M_Path + "\\setting\\" + Deck_Name);
                    WritePrivateProfileString("Back3", "F2_B_SIZE", F2_1, M_Path + "\\setting\\" + Deck_Name);
                    WritePrivateProfileString("Back4", "LA2_FONT", LA2_X + "," + LA2_Y + "," + LA2_SIZE + "," + LA2_FONT + "," + LA2_COLOR, M_Path + "\\setting\\" + Deck_Name);
                }
                //X, Y, SIZE, FONT, COLOR순서로 함
            }

            SV_CO = 1;
        }


        private void Main_T_MouseDown(object sender, MouseEventArgs e)
        {
            if (T_Count == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    MouseDownLocation = e.Location;
                }
            }
            
        }

        private void Main_T_MouseMove(object sender, MouseEventArgs e)
        {
            if (T_Count == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Main_T.Left = e.X + Main_T.Left - MouseDownLocation.X;
                    Main_T.Top = e.Y + Main_T.Top - MouseDownLocation.Y;
                }
            }
        }

        private void Main_T_MouseLeave(object sender, EventArgs e)
        {

            
        }

        private void T_option_b_Click(object sender, EventArgs e)
        {
            if (F_B_2 == 0)
            {
                fontDialog1.ShowColor = true;

                fontDialog1.Font = Main_T.Font;
                fontDialog1.Color = Main_T.ForeColor;

                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Main_T.Font = fontDialog1.Font;
                    Main_T.ForeColor = fontDialog1.Color;
                }

                LA_SIZE = Math.Round(Convert.ToDouble(Main_T.Font.Size)).ToString(); //텍스트 사이즈
                LA_FONT = Main_T.Font.Name.ToString(); //텍스트 폰트
                LA_COLOR = Main_T.ForeColor.ToArgb().ToString(); //텍스트 폰트 RGB컬러
            }
            else
            {
                fontDialog1.ShowColor = true;

                fontDialog1.Font = Main_T.Font;
                fontDialog1.Color = Main_T.ForeColor;

                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    Main_T.Font = fontDialog1.Font;
                    Main_T.ForeColor = fontDialog1.Color;
                }

                LA2_SIZE = Math.Round(Convert.ToDouble(Main_T.Font.Size)).ToString(); //텍스트 사이즈
                LA2_FONT = Main_T.Font.Name.ToString(); //텍스트 폰트
                LA2_COLOR = Main_T.ForeColor.ToArgb().ToString(); //텍스트 폰트 RGB컬러
            }
        }

        private void New_w_Click(object sender, EventArgs e)
        {
            Form2 MyForm1 = new Form2();
            MyForm1.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("F1:텍스트변경" + Environment.NewLine + "F2:사진변경" + Environment.NewLine + "F3:텍스트이동모드전환 ON/OFF" + Environment.NewLine + "F4:초기화" + Environment.NewLine + "F5:저장");
        }


        public int F_B_2 = 0;
        private void back_btn_Click(object sender, EventArgs e)
        {
            if (Form1.Plan_B == 1)
            {
                F_B = 1;
                //F_B_2 = 0;
                if (F_B_2 == 1)//뒷면일때
                {
                    string[] temp1 = this.Size.ToString().Split(',');
                    string[] temp1_1 = temp1[0].Split('=');
                    string[] temp1_2 = temp1[1].Split('=');
                    F2_1_Width = temp1_1[1];
                    F2_1_Height = temp1_2[1].Replace("}", "");
                    F2_1 = this.Size.ToString();

                    Front_Load(); //앞면로드
                    back_btn.Text = "뒷면";
                    F_B_2 = 0;
                }
                else //F_B_2 = 0 앞면일때
                {
                    string[] temp1 = this.Size.ToString().Split(',');
                    string[] temp1_1 = temp1[0].Split('=');
                    string[] temp1_2 = temp1[1].Split('=');
                    F2_Width = temp1_1[1];
                    F2_Height = temp1_2[1].Replace("}", "");
                    F2 = this.Size.ToString();

                    Back_Load(); //뒷면로드
                    back_btn.Text = "앞면";
                    F_B_2 = 1;
                }
            }

            else
            {
                if (F_B == 0)
                {
                    string[] temp1 = this.Size.ToString().Split(',');
                    string[] temp1_1 = temp1[0].Split('=');
                    string[] temp1_2 = temp1[1].Split('=');
                    F2_Width = temp1_1[1];
                    F2_Height = temp1_2[1].Replace("}", "");
                    F2 = this.Size.ToString();

                    this.Size = new Size(900, 400);
                    Main_T.Text = "편집할 텍스트";
                    Main_T.Font = new Font("나눔고딕", 28, FontStyle.Bold);
                    Main_T.ForeColor = Color.FromArgb(-16777216);
                    Main_T.Left = 28;
                    Main_T.Top = 74;

                    MainText_B = Main_T.Text;
                    F2_1_Width = "900";
                    F2_1_Height = "400";
                    LA2_FONT = "나눔고딕";
                    LA2_SIZE = "28";
                    LA2_COLOR = "-16777216";
                    LA2_X = "28";
                    LA2_Y = "74";

                    pictureBox1.Image = MyImage2;

                    back_btn.Text = "앞면";
                    F_B = 1;
                    F_B_2 = 1;



                }
                else
                {
                    if (F_B_2 == 1)//뒷면일때
                    {
                        string[] temp1 = this.Size.ToString().Split(',');
                        string[] temp1_1 = temp1[0].Split('=');
                        string[] temp1_2 = temp1[1].Split('=');
                        F2_1_Width = temp1_1[1];
                        F2_1_Height = temp1_2[1].Replace("}", "");
                        F2_1 = this.Size.ToString();

                        Front_Load(); //앞면로드
                        back_btn.Text = "뒷면";
                        F_B_2 = 0;
                    }
                    else //F_B_2 = 0 앞면일때
                    {
                        string[] temp1 = this.Size.ToString().Split(',');
                        string[] temp1_1 = temp1[0].Split('=');
                        string[] temp1_2 = temp1[1].Split('=');
                        F2_Width = temp1_1[1];
                        F2_Height = temp1_2[1].Replace("}", "");
                        F2 = this.Size.ToString();

                        Back_Load(); //뒷면로드
                        back_btn.Text = "앞면";
                        F_B_2 = 1;
                    }

                }
            }
        }

        public void Back_Load()//뒤
        {
            //창크기 재설정
            this.Size = new Size(Convert.ToInt32(F2_1_Width), Convert.ToInt32(F2_1_Height));

            //이미지 재설정
            pictureBox1.Image = (Image)MyImage2;
            Path_C = 1;

            //텍스트 재설정
            Main_T.Text = MainText_B;

            //폰트 재설정
            Main_T.Font = new Font(LA2_FONT, Convert.ToInt32(LA2_SIZE), FontStyle.Regular);
            Main_T.ForeColor = Color.FromArgb(Convert.ToInt32(LA2_COLOR));
            Main_T.Left = Convert.ToInt32(LA2_X);
            Main_T.Top = Convert.ToInt32(LA2_Y);
            //Main_T.Text = MainText;

            Main_T.BackColor = Color.Transparent;
            Main_T.Parent = pictureBox1;
        }

        public void Front_Load() //앞
        {
            //창크기 재설정
            this.Size = new Size(Convert.ToInt32(F2_Width), Convert.ToInt32(F2_Height));

            //이미지 재설정
            pictureBox1.Image = (Image)MyImage1;
            Path_C = 1;

            //텍스트 재설정
            Main_T.Text = MainText;

            //폰트 재설정
            Main_T.Font = new Font(LA_FONT, Convert.ToInt32(LA_SIZE), FontStyle.Regular);
            Main_T.ForeColor = Color.FromArgb(Convert.ToInt32(LA_COLOR));
            Main_T.Left = Convert.ToInt32(LA_X);
            Main_T.Top = Convert.ToInt32(LA_Y);
            //Main_T.Text = MainText;

            Main_T.BackColor = Color.Transparent;
            Main_T.Parent = pictureBox1;

        }

        public void Exit()
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("창을닫으시겠습니까?", "확인 취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //정말로 닫으시겠습니까? 예 아니오 
                //저장 여부는 SV_CO 로
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Main_T_Click(object sender, EventArgs e)
        {
            if(F_B_2 == 0)
            {
                LA_X = Main_T.Location.X.ToString();
                LA_Y = Main_T.Location.Y.ToString();
            }
            else
            {
                LA2_X = Main_T.Location.X.ToString();
                LA2_Y = Main_T.Location.Y.ToString();
            }

        }

        private void Form2_Resize(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!base.ProcessCmdKey(ref msg, keyData))
            {
                if (keyData.Equals(Keys.F1))
                {
                    Form3 MyForm = new Form3();
                    MyForm.ShowDialog();
                    Main_T.Text = Form3.Passvalue;
                    if (F_B_2 == 0)
                    {
                        MainText = Main_T.Text;
                    }
                    else
                    {
                        MainText_B = Main_T.Text;
                    }
                    return true;
                }

                else if (keyData.Equals(Keys.F2))
                {
                    try
                    {
                        Main_T.BackColor = Color.Transparent;
                        Main_T.Parent = pictureBox1;


                        if (Form1.Plan_B == 1)
                        {
                            if (F_B_2 == 1)
                            {
                                OpenFileDialog pFileDlg = new OpenFileDialog();
                                pFileDlg.Filter = "All Files(*.*)|*.*";
                                pFileDlg.Title = "사진 파일을 선택하여 주세요.";
                                if (pFileDlg.ShowDialog() == DialogResult.OK)
                                {
                                    Path_P = pFileDlg.FileName;
                                }
                                MyImage2 = new Bitmap(Path_P);
                                pictureBox1.Image = (Image)MyImage2;

                                IMG_NAME_B = Path.GetFileName(Path_P);
                                if (!File.Exists(Form1.Path_INI.Replace("\\setting\\" + Path.GetFileName(Form1.Path_INI), "") + "\\img\\" + IMG_NAME_B))
                                {
                                    File.Copy(Path_P, Form1.Path_INI.Replace("\\setting\\" + Path.GetFileName(Form1.Path_INI), "") + "\\img\\" + IMG_NAME_B);
                                }
                            }
                            else
                            {
                                OpenFileDialog pFileDlg = new OpenFileDialog();
                                pFileDlg.Filter = "All Files(*.*)|*.*";
                                pFileDlg.Title = "사진 파일을 선택하여 주세요.";
                                if (pFileDlg.ShowDialog() == DialogResult.OK)
                                {
                                    Path_P = pFileDlg.FileName;
                                }
                                MyImage1 = new Bitmap(Path_P);
                                pictureBox1.Image = (Image)MyImage1;

                                IMG_NAME = Path.GetFileName(Path_P);
                                if (!File.Exists(Form1.Path_INI.Replace("\\setting\\" + Path.GetFileName(Form1.Path_INI), "") + "\\img\\" + IMG_NAME))
                                {
                                    File.Copy(Path_P, Form1.Path_INI.Replace("\\setting\\" + Path.GetFileName(Form1.Path_INI), "") + "\\img\\" + IMG_NAME);
                                }
                            }
                        }
                        else
                        {
                            if (F_B_2 == 1)
                            {
                                OpenFileDialog pFileDlg = new OpenFileDialog();
                                pFileDlg.Filter = "All Files(*.*)|*.*";
                                pFileDlg.Title = "사진 파일을 선택하여 주세요.";
                                if (pFileDlg.ShowDialog() == DialogResult.OK)
                                {
                                    Path_P = pFileDlg.FileName;
                                }
                                MyImage2 = new Bitmap(Path_P);
                                pictureBox1.Image = (Image)MyImage2;

                                IMG_NAME_B = Path.GetFileName(Path_P);
                                if (!File.Exists(M_Path + "\\img\\" + IMG_NAME_B))
                                {
                                    File.Copy(Path_P, M_Path + "\\img\\" + IMG_NAME_B);
                                }
                            }
                            else
                            {
                                OpenFileDialog pFileDlg = new OpenFileDialog();
                                pFileDlg.Filter = "All Files(*.*)|*.*";
                                pFileDlg.Title = "사진 파일을 선택하여 주세요.";
                                if (pFileDlg.ShowDialog() == DialogResult.OK)
                                {
                                    Path_P = pFileDlg.FileName;
                                }
                                MyImage1 = new Bitmap(Path_P);
                                pictureBox1.Image = (Image)MyImage1;

                                IMG_NAME = Path.GetFileName(Path_P);
                                if (!File.Exists(M_Path + "\\img\\" + IMG_NAME))
                                {
                                    File.Copy(Path_P, M_Path + "\\img\\" + IMG_NAME);
                                }
                            }

                        }
                        Path_C = 1;
                    }
                    catch
                    {
                    }
                    return true;

                }
                else if (keyData.Equals(Keys.F3))
                {

                    if (T_Count == 0)
                    {
                        if (Path_C == 1)
                        {
                            pictureBox1.BackColor = Color.White;
                        }
                        else if (Path_C == 0)
                        {
                            Main_T.BackColor = Color.White;
                            pictureBox1.BackColor = Color.White;
                        }
                        Move_T.ForeColor = Color.Green;
                        Move_T.Text = "이동모드 ON";
                        T_Count = 1;
                    }
                    else if (T_Count == 1)
                    {

                        if (Path_C == 1)
                        {
                            pictureBox1.BackColor = Color.DimGray;
                        }
                        else
                        {
                            pictureBox1.BackColor = Color.DimGray;
                        }
                        Main_T.BackColor = Color.Transparent;
                        Main_T.Parent = pictureBox1;

                        Move_T.ForeColor = Color.Red;
                        Move_T.Text = "이동모드 OFF";
                        T_Count = 0;
                    }
                    return true;
                }

                else if (keyData.Equals(Keys.F4)) //초기화
                {
                    //앞

                    F2_Width = "900";
                    F2_Height = "400";
                    LA_FONT = "나눔고딕";
                    LA_SIZE = "28";
                    LA_COLOR = "-16777216";
                    LA_X = "28";
                    LA_Y = "74";

                    //뒤
                    F2_1_Width = "900";
                    F2_1_Height = "400";
                    F2_1 = "";
                    LA2_X = "28";
                    LA2_Y = "74";
                    LA2_SIZE = "28";
                    LA2_FONT = "나눔고딕";
                    LA2_COLOR = "-16777216";

                    LA2_FAM = ""; //임시로생성


                    MainText = "편집할 텍스트";
                    MainText_B = "편집할 텍스트";

                    SV_CO = 0; //저장 했는지 확인변수

                    temp = "";
                    Path_P = "";
                    Path_C = 0;
                    T_Count = 0;

                    IMG_NAME = "";
                    IMG_NAME_B = "";
                    F_B = 0;

                    MyImage1 = null;
                    MyImage2 = null;

                    this.Size = new Size(Convert.ToInt32(F2_Width), Convert.ToInt32(F2_Height));
                    pictureBox1.Image = null;
                    pictureBox1.BackColor = Color.DimGray;

                    Main_T.Text = "편집할 텍스트";
                    Main_T.Font = new Font("나눔고딕", 28, FontStyle.Regular);
                    Main_T.ForeColor = Color.FromArgb(-16777216);
                    Main_T.Left = 28;
                    Main_T.Top = 74;



                    //첫 생성
                    LA_X = Main_T.Location.X.ToString(); //텍스트 X좌표
                    LA_Y = Main_T.Location.Y.ToString(); //텍스트 Y좌표
                    LA_SIZE = Main_T.Font.Size.ToString(); //텍스트 사이즈
                    LA_FONT = Main_T.Font.Name.ToString(); //텍스트 폰트
                    LA_COLOR = Main_T.ForeColor.ToArgb().ToString(); //텍스트 폰트 RGB컬러

                    LA2_X = Main_T.Location.X.ToString(); //텍스트 X좌표
                    LA2_Y = Main_T.Location.Y.ToString(); //텍스트 Y좌표
                    LA2_SIZE = Main_T.Font.Size.ToString(); //텍스트 사이즈
                    LA2_FONT = Main_T.Font.Name.ToString(); //텍스트 폰트
                    LA2_COLOR = Main_T.ForeColor.ToArgb().ToString(); //텍스트 폰트 RGB컬러

                    return true;

                }
                else if (keyData.Equals(Keys.F5))
                {
                    if (title_T.Text == "" || title_T.Text == string.Empty)
                    {
                        MessageBox.Show("카드이름을 먼저 정해주세요");
                    }
                    else
                    {
                        Save();
                        MessageBox.Show("저장완료");
                    }
                    
                    return true;
                }

                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }

}
