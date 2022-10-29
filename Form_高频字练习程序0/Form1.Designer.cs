namespace Form_高频字练习程序0 {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.wordPnl = new System.Windows.Forms.Panel();
            this.btn_sure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择默认文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择二十五史常用字文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lable_error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_content_practicing = new System.Windows.Forms.Label();
            this.lable_index_currentWord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_practiceTimes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wordPnl
            // 
            this.wordPnl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.wordPnl.Location = new System.Drawing.Point(307, 66);
            this.wordPnl.Name = "wordPnl";
            this.wordPnl.Size = new System.Drawing.Size(126, 122);
            this.wordPnl.TabIndex = 0;
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(332, 278);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 31);
            this.btn_sure.TabIndex = 1;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "（按下回车键自动触发本按钮）";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.说明ToolStripMenuItem.Text = "说明";
            this.说明ToolStripMenuItem.Click += new System.EventHandler(this.说明ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择默认文本ToolStripMenuItem,
            this.选择二十五史常用字文本ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 选择默认文本ToolStripMenuItem
            // 
            this.选择默认文本ToolStripMenuItem.Name = "选择默认文本ToolStripMenuItem";
            this.选择默认文本ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.选择默认文本ToolStripMenuItem.Text = "选择默认常用字文本";
            this.选择默认文本ToolStripMenuItem.Click += new System.EventHandler(this.选择默认文本ToolStripMenuItem_Click);
            // 
            // 选择二十五史常用字文本ToolStripMenuItem
            // 
            this.选择二十五史常用字文本ToolStripMenuItem.Name = "选择二十五史常用字文本ToolStripMenuItem";
            this.选择二十五史常用字文本ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.选择二十五史常用字文本ToolStripMenuItem.Text = "选择二十五史常用字文本";
            this.选择二十五史常用字文本ToolStripMenuItem.Click += new System.EventHandler(this.选择二十五史常用字文本ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(332, 213);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 46);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lable_error
            // 
            this.lable_error.AutoSize = true;
            this.lable_error.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable_error.ForeColor = System.Drawing.Color.Red;
            this.lable_error.Location = new System.Drawing.Point(455, 125);
            this.lable_error.Name = "lable_error";
            this.lable_error.Size = new System.Drawing.Size(72, 20);
            this.lable_error.TabIndex = 5;
            this.lable_error.Text = "错误！";
            this.lable_error.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "正在练习：";
            // 
            // label_content_practicing
            // 
            this.label_content_practicing.AutoSize = true;
            this.label_content_practicing.Location = new System.Drawing.Point(100, 60);
            this.label_content_practicing.Name = "label_content_practicing";
            this.label_content_practicing.Size = new System.Drawing.Size(0, 15);
            this.label_content_practicing.TabIndex = 7;
            // 
            // lable_index_currentWord
            // 
            this.lable_index_currentWord.AutoSize = true;
            this.lable_index_currentWord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable_index_currentWord.Location = new System.Drawing.Point(360, 31);
            this.lable_index_currentWord.Name = "lable_index_currentWord";
            this.lable_index_currentWord.Size = new System.Drawing.Size(19, 20);
            this.lable_index_currentWord.TabIndex = 8;
            this.lable_index_currentWord.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(15, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "总练习次数：";
            // 
            // lbl_practiceTimes
            // 
            this.lbl_practiceTimes.AutoSize = true;
            this.lbl_practiceTimes.Location = new System.Drawing.Point(135, 372);
            this.lbl_practiceTimes.Name = "lbl_practiceTimes";
            this.lbl_practiceTimes.Size = new System.Drawing.Size(15, 15);
            this.lbl_practiceTimes.TabIndex = 10;
            this.lbl_practiceTimes.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "当前选中的文本：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 398);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_practiceTimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lable_index_currentWord);
            this.Controls.Add(this.label_content_practicing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable_error);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.wordPnl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高频字练习程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel wordPnl;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lable_error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_content_practicing;
        private System.Windows.Forms.Label lable_index_currentWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_practiceTimes;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择默认文本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择二十五史常用字文本ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

