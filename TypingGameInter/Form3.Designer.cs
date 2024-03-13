namespace TypingGameInter
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblScreen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblword = new System.Windows.Forms.Label();
            this.lblwrong = new System.Windows.Forms.Label();
            this.lblright = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMistakes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChosenTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(624, 36);
            this.label5.TabIndex = 33;
            this.label5.Text = "Click \"Timer\" first before you enter the word";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name:";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(806, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "RAPID TYPER TESTER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-23, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(961, 50);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lblScreen
            // 
            this.lblScreen.BackColor = System.Drawing.Color.Transparent;
            this.lblScreen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.ForeColor = System.Drawing.Color.Red;
            this.lblScreen.Location = new System.Drawing.Point(442, 79);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(135, 60);
            this.lblScreen.TabIndex = 25;
            this.lblScreen.Text = "0";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScreen.Click += new System.EventHandler(this.lblScreen_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(470, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "30";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(347, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 47);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckGame);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Enter to check the Word";
            // 
            // lblword
            // 
            this.lblword.BackColor = System.Drawing.Color.Transparent;
            this.lblword.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.Location = new System.Drawing.Point(341, 125);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(328, 84);
            this.lblword.TabIndex = 21;
            this.lblword.Text = "Word";
            this.lblword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblwrong
            // 
            this.lblwrong.AutoSize = true;
            this.lblwrong.BackColor = System.Drawing.Color.Transparent;
            this.lblwrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwrong.Location = new System.Drawing.Point(584, 50);
            this.lblwrong.Name = "lblwrong";
            this.lblwrong.Size = new System.Drawing.Size(91, 20);
            this.lblwrong.TabIndex = 20;
            this.lblwrong.Text = "Mistake: 0";
            this.lblwrong.Click += new System.EventHandler(this.lblwrong_Click);
            // 
            // lblright
            // 
            this.lblright.AutoSize = true;
            this.lblright.BackColor = System.Drawing.Color.Transparent;
            this.lblright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblright.Location = new System.Drawing.Point(355, 50);
            this.lblright.Name = "lblright";
            this.lblright.Size = new System.Drawing.Size(76, 20);
            this.lblright.TabIndex = 19;
            this.lblright.Text = "Score: 0";
            this.lblright.Click += new System.EventHandler(this.lblright_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(74, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 20);
            this.NameLabel.TabIndex = 34;
            this.NameLabel.Text = "Name:";
            this.NameLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(361, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 35;
            this.button3.Text = "15";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(577, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 36;
            this.button4.Text = "60";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvName,
            this.dgvScores,
            this.dgvMistakes,
            this.dgvChosenTime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(307, 333);
            this.dataGridView1.TabIndex = 39;
            // 
            // dgvID
            // 
            this.dgvID.HeaderText = "ID";
            this.dgvID.MinimumWidth = 6;
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Visible = false;
            this.dgvID.Width = 6;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Width = 70;
            // 
            // dgvScores
            // 
            this.dgvScores.HeaderText = "Scores";
            this.dgvScores.MinimumWidth = 6;
            this.dgvScores.Name = "dgvScores";
            this.dgvScores.ReadOnly = true;
            this.dgvScores.Width = 60;
            // 
            // dgvMistakes
            // 
            this.dgvMistakes.HeaderText = "Mistakes";
            this.dgvMistakes.MinimumWidth = 6;
            this.dgvMistakes.Name = "dgvMistakes";
            this.dgvMistakes.ReadOnly = true;
            this.dgvMistakes.Width = 60;
            // 
            // dgvChosenTime
            // 
            this.dgvChosenTime.HeaderText = "Time";
            this.dgvChosenTime.MinimumWidth = 6;
            this.dgvChosenTime.Name = "dgvChosenTime";
            this.dgvChosenTime.ReadOnly = true;
            this.dgvChosenTime.Width = 90;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.lblwrong);
            this.Controls.Add(this.lblright);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.Label lblwrong;
        private System.Windows.Forms.Label lblright;
        public System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMistakes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvChosenTime;
    }
}