namespace Deck_Shuffler_Engine
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PathF_T = new System.Windows.Forms.TextBox();
            this.PathF_b = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Deck_Name = new System.Windows.Forms.Label();
            this.Deck_T = new System.Windows.Forms.TextBox();
            this.Project_ST = new System.Windows.Forms.Button();
            this.Project_Open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DeckName_help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PathF_T
            // 
            this.PathF_T.Location = new System.Drawing.Point(109, 58);
            this.PathF_T.Name = "PathF_T";
            this.PathF_T.Size = new System.Drawing.Size(224, 21);
            this.PathF_T.TabIndex = 0;
            // 
            // PathF_b
            // 
            this.PathF_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathF_b.ForeColor = System.Drawing.Color.White;
            this.PathF_b.Location = new System.Drawing.Point(32, 58);
            this.PathF_b.Name = "PathF_b";
            this.PathF_b.Size = new System.Drawing.Size(74, 21);
            this.PathF_b.TabIndex = 1;
            this.PathF_b.Text = "경로지정";
            this.PathF_b.UseVisualStyleBackColor = true;
            this.PathF_b.Click += new System.EventHandler(this.PathF_b_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(386, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 26);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Deck_Name
            // 
            this.Deck_Name.AutoSize = true;
            this.Deck_Name.ForeColor = System.Drawing.Color.White;
            this.Deck_Name.Location = new System.Drawing.Point(53, 101);
            this.Deck_Name.Name = "Deck_Name";
            this.Deck_Name.Size = new System.Drawing.Size(53, 12);
            this.Deck_Name.TabIndex = 3;
            this.Deck_Name.Text = "덱이름 : ";
            // 
            // Deck_T
            // 
            this.Deck_T.Location = new System.Drawing.Point(109, 96);
            this.Deck_T.Name = "Deck_T";
            this.Deck_T.Size = new System.Drawing.Size(224, 21);
            this.Deck_T.TabIndex = 4;
            // 
            // Project_ST
            // 
            this.Project_ST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Project_ST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Project_ST.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Project_ST.ForeColor = System.Drawing.Color.White;
            this.Project_ST.Location = new System.Drawing.Point(66, 191);
            this.Project_ST.Name = "Project_ST";
            this.Project_ST.Size = new System.Drawing.Size(290, 74);
            this.Project_ST.TabIndex = 5;
            this.Project_ST.Text = "덱 생성";
            this.Project_ST.UseVisualStyleBackColor = false;
            this.Project_ST.Click += new System.EventHandler(this.Project_ST_Click);
            // 
            // Project_Open
            // 
            this.Project_Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Project_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Project_Open.Font = new System.Drawing.Font("굴림", 18F);
            this.Project_Open.ForeColor = System.Drawing.Color.White;
            this.Project_Open.Location = new System.Drawing.Point(66, 299);
            this.Project_Open.Name = "Project_Open";
            this.Project_Open.Size = new System.Drawing.Size(290, 74);
            this.Project_Open.TabIndex = 6;
            this.Project_Open.Text = "카드 열기";
            this.Project_Open.UseVisualStyleBackColor = false;
            this.Project_Open.Click += new System.EventHandler(this.Project_Open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DeckName_help
            // 
            this.DeckName_help.AutoSize = true;
            this.DeckName_help.ForeColor = System.Drawing.Color.White;
            this.DeckName_help.Location = new System.Drawing.Point(53, 127);
            this.DeckName_help.Name = "DeckName_help";
            this.DeckName_help.Size = new System.Drawing.Size(289, 12);
            this.DeckName_help.TabIndex = 7;
            this.DeckName_help.Text = "지정한 경로안에 덱 이름으로 된 폴더가 생성 됩니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(415, 402);
            this.Controls.Add(this.DeckName_help);
            this.Controls.Add(this.Project_Open);
            this.Controls.Add(this.Project_ST);
            this.Controls.Add(this.Deck_T);
            this.Controls.Add(this.Deck_Name);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PathF_b);
            this.Controls.Add(this.PathF_T);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox PathF_T;
        private System.Windows.Forms.Button Project_ST;
        private System.Windows.Forms.TextBox Deck_T;
        private System.Windows.Forms.Label Deck_Name;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button PathF_b;
        private System.Windows.Forms.Button Project_Open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label DeckName_help;
    }
}

