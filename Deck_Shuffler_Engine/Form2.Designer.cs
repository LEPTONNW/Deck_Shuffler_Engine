namespace Deck_Shuffler_Engine
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.T_option_b = new System.Windows.Forms.Button();
            this.Main_T = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.New_w = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.title_T = new System.Windows.Forms.TextBox();
            this.Move_T = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(2, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // T_option_b
            // 
            this.T_option_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.T_option_b.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_option_b.ForeColor = System.Drawing.Color.White;
            this.T_option_b.Location = new System.Drawing.Point(2, 0);
            this.T_option_b.Name = "T_option_b";
            this.T_option_b.Size = new System.Drawing.Size(47, 43);
            this.T_option_b.TabIndex = 1;
            this.T_option_b.Text = "글꼴";
            this.T_option_b.UseVisualStyleBackColor = true;
            this.T_option_b.Click += new System.EventHandler(this.T_option_b_Click);
            // 
            // Main_T
            // 
            this.Main_T.AutoSize = true;
            this.Main_T.BackColor = System.Drawing.Color.DimGray;
            this.Main_T.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Main_T.Location = new System.Drawing.Point(28, 74);
            this.Main_T.Name = "Main_T";
            this.Main_T.Size = new System.Drawing.Size(239, 43);
            this.Main_T.TabIndex = 2;
            this.Main_T.Text = "편집할 텍스트";
            this.Main_T.Click += new System.EventHandler(this.Main_T_Click);
            this.Main_T.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_T_MouseDown);
            this.Main_T.MouseLeave += new System.EventHandler(this.Main_T_MouseLeave);
            this.Main_T.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_T_MouseMove);
            // 
            // New_w
            // 
            this.New_w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_w.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_w.ForeColor = System.Drawing.Color.White;
            this.New_w.Location = new System.Drawing.Point(49, 0);
            this.New_w.Name = "New_w";
            this.New_w.Size = new System.Drawing.Size(48, 43);
            this.New_w.TabIndex = 3;
            this.New_w.Text = "새창";
            this.New_w.UseVisualStyleBackColor = true;
            this.New_w.Click += new System.EventHandler(this.New_w_Click);
            // 
            // help
            // 
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.ForeColor = System.Drawing.Color.White;
            this.help.Location = new System.Drawing.Point(97, 1);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(48, 42);
            this.help.TabIndex = 4;
            this.help.Text = "설명";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // back_btn
            // 
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(145, 1);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(48, 42);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "뒷면";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(217, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(73, 18);
            this.title.TabIndex = 6;
            this.title.Text = "카드이름 : ";
            // 
            // title_T
            // 
            this.title_T.Location = new System.Drawing.Point(283, 15);
            this.title_T.Name = "title_T";
            this.title_T.Size = new System.Drawing.Size(279, 21);
            this.title_T.TabIndex = 7;
            // 
            // Move_T
            // 
            this.Move_T.AutoSize = true;
            this.Move_T.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Move_T.ForeColor = System.Drawing.Color.Red;
            this.Move_T.Location = new System.Drawing.Point(564, 17);
            this.Move_T.Name = "Move_T";
            this.Move_T.Size = new System.Drawing.Size(94, 18);
            this.Move_T.TabIndex = 8;
            this.Move_T.Text = "이동모드 OFF";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.Move_T);
            this.Controls.Add(this.title_T);
            this.Controls.Add(this.title);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.Main_T);
            this.Controls.Add(this.help);
            this.Controls.Add(this.New_w);
            this.Controls.Add(this.T_option_b);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "편집기";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button T_option_b;
        private System.Windows.Forms.Label Main_T;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button New_w;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox title_T;
        private System.Windows.Forms.Label Move_T;
    }
}