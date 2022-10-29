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
using System.Xml.Linq;

namespace Form_高频字练习程序0 {
    public partial class Form1 : Form {
        public static Form1 form;
        private int _startIndex;
        private int _endIndex;
        private int _practiceTimes;
        /// <summary>
        /// 每次练习的数量
        /// </summary>
        private const int COUNT = 100;
        private int _index_currentWord = 0;
        private string _pathOfWordsTxt = "现代汉语常用字前5000.txt";
        private string _pathOfPracticeTxt = "practice.txt";
        /// <summary>
        /// 当前选中的汉字列表
        /// </summary>
        public List<char> List_currentWord { get; set; } = new List<char>();

        public List<char> List_word { get; set; } = new List<char>();

        public Form1() {
            InitializeComponent();
            Init();

        }

        /// <summary>
        /// 选中模式时，会进行洗牌，然后直接绘制第一个下标的汉字到图片上。
        /// </summary>
        /// <param name="startIndex"></param>
        public void Choose_mode(int startIndex) {
            Set_wordIndex(startIndex);
            Set_currentWord();
            Draw_wordToPnl();
        }

        /// <summary>
        /// 设置当前选中的汉字列表。并进行洗牌。
        /// </summary>
        private void Set_currentWord() {
            List_currentWord = new List<char>(COUNT);
            for (int i = 0; i < COUNT; i++) {
                List_currentWord.Add(List_word[i+_startIndex]);
            }
            Shuffle_currentWord();
        }
        /// <summary>
        /// 洗牌算法
        /// </summary>
        private void Shuffle_currentWord() {
            Random r = new Random();
            for (int i = COUNT-1; i >= 0; i--) {
                int rIndex = r.Next(0, i);
                char temp = List_currentWord[i];
                List_currentWord[i] = List_currentWord[rIndex];
                List_currentWord[rIndex] = temp;
            }
        }

        private void 前100ToolStripMenuItem_Click(object sender, EventArgs e) {
            Choose_mode(0);
            Change_text_about_lable_content_pricticing(sender);

        }
        /// <summary>
        /// 设置startIndex和endIndex的下标。
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Set_wordIndex(int startIndex) {
            _startIndex = startIndex;
            _endIndex = _startIndex + COUNT;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {
            Choose_mode(100);
            Change_text_about_lable_content_pricticing(sender);


        }

        private void Form1_Load(object sender, EventArgs e) {
           
        }
        private void Init() {
            if (Exist_wordsTxt()) {
                Load_wordsTxt();
               
            }
            else {
                MessageBox.Show($"请确认{_pathOfWordsTxt}存在于本程序根目录下！");
            }
            if (Exist_practiceTxt()) {
                Load_practiceTxt();

            }
            else {
                _practiceTimes = 0;
            }
            Init_toolStripMenuItems();
            lbl_practiceTimes.Text = _practiceTimes.ToString();

        }

        private void Init_toolStripMenuItems() {
            int startNum_increaseBy500 = 1;
            int startNum_increaseBy100 = 1;

            const int COUNT500 = 500;
            const int COUNT100 = 100;
            //动态创建10个菜单按钮的子按钮
            for (int i = 0; i < 10; i++) {
                ToolStripMenuItem toolStripDropDown = new ToolStripMenuItem() {
                    Text = $"高频字{startNum_increaseBy500}~{startNum_increaseBy500 + COUNT500-1}"
                };
                //继续为子按钮创建子按钮
                for (int j = 0; j < 5; j++) {
                    //注意闭包
                    int newStartIndex = startNum_increaseBy100;
                    var menuItem = new ToolStripMenuItem() {
                        Text = $"{startNum_increaseBy100}~{startNum_increaseBy100 + COUNT100-1}"
                    };
                    //lambda表达式很好地解决了绑定事件时的参数限定问题。
                    menuItem.Click += (s, e) => {
                        Choose_mode(newStartIndex - 1);
                        Change_text_about_lable_content_pricticing(s);
                    };
                    toolStripDropDown.DropDownItems.Add(menuItem);
                    startNum_increaseBy100 += COUNT100;
                }
                选项ToolStripMenuItem.DropDownItems.Add(toolStripDropDown);
                startNum_increaseBy500 += COUNT500;
            }
        }





        /// <summary>
        /// 绘制之前会把面板清空
        /// </summary>
        private void Draw_wordToPnl() {
            Graphics g_wordPnl = wordPnl.CreateGraphics();
            g_wordPnl.Clear(wordPnl.BackColor);
            g_wordPnl.DrawString(List_currentWord[_index_currentWord].ToString(), new Font("微软雅黑", 50, FontStyle.Regular), Brushes.Black, new Point((wordPnl.Width - 50) / 5-5, (wordPnl.Height - 50) / 5 -8));
        }

        private void Load_wordsTxt() {
            label5.Text = _pathOfWordsTxt;
            string words = File.ReadAllText(_pathOfWordsTxt);
            List_word.Clear();
            foreach (char ch in words) {
                List_word.Add(ch);
            }
        }
        private void Load_practiceTxt() {
            string times = File.ReadAllText(_pathOfPracticeTxt);
            _practiceTimes = Convert.ToInt32(times);
        }
        private bool Exist_practiceTxt() {
            return File.Exists(_pathOfPracticeTxt);
        }
        private bool Exist_wordsTxt() {
            return File.Exists(_pathOfWordsTxt);
        }
        /// <summary>
        /// 如果判断错误会显示红色“错误”。否则，汉字下标++。
        /// </summary>
        private bool Is_correct() {
            if ( textBox1.Text == List_currentWord[_index_currentWord].ToString()) {
                return true;
            }
            else {
              
                return false;
            }
        }
        private void Update_practiceTimes() {
            _practiceTimes++;
            lbl_practiceTimes.Text = _practiceTimes.ToString();
        }
        private void button1_Click(object sender, EventArgs e) {
            if (Is_correct()) {
                lable_error.Visible = false;
                lable_index_currentWord.Text = (_index_currentWord + 1).ToString();
                Increase_index_currentWord();
                Draw_wordToPnl();
                Update_practiceTimes();

            }
            else {
                lable_error.Visible = true;
            }
            textBox1.Text = "";

        }
        /// <summary>
        /// 如果越界了则锁住按钮，弹出通知栏“请重新开始”。
        /// </summary>
        private void Increase_index_currentWord() {
            
            _index_currentWord++;

            if (_index_currentWord >= COUNT) {
                _index_currentWord = 0;
                Shuffle_currentWord();
                MessageBox.Show("本次练习结束，请重新选择模式！");
            }

        }

  

        public void Change_text_about_lable_content_pricticing(object sender) {
            ToolStripMenuItem enuItem = sender as ToolStripMenuItem;
            label_content_practicing.Text = enuItem.Text;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e) {
            Choose_mode(400);
            Change_text_about_lable_content_pricticing(sender);


        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            if (btn_sure.Enabled && textBox1.Text != "") {
                 button1_Click(sender, e);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
          
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            var file = File.CreateText(_pathOfPracticeTxt);
            file.Write(_practiceTimes);
            file.Close();
        }

        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("现代汉语常用字字频(选自各种类别的13本热门网络小说）：\n字数\t覆盖面（ %）\n100\t45.425\n500\t76.885\n1000\t88.578\n1500\t94.002\n" +
                "2000\t96.839\n3000\t99.230\n4000\t99.860\n5000\t99.982" +
                "\n古代汉语常用字字频(选自二十四史+清史稿）：\n字数\t覆盖面（ %）\n100\t36.525\n500\t70.826\n1000\t85.740\n1500\t92.215\n" +
                "2000\t95.418\n3000\t98.325\n4000\t99.336\n5000\t99.719" +
                "\n口语常用字字频(选自本人经常呆的一个6年qq群）：\n字数\t覆盖面（ %）\n100\t49.306\n500\t81.949\n1000\t92.782\n1500\t96.625\n" +
                "2000\t98.329\n3000\t99.556\n本程序作者：桂南鄙士");
        }

        private void button1_Click_1(object sender, EventArgs e) {
            Draw_wordToPnl();
        }

        private void 选择默认文本ToolStripMenuItem_Click(object sender, EventArgs e) {
            _pathOfWordsTxt = "现代汉语常用字前5000.txt";
            Load_wordsTxt();
        }

        private void 选择二十五史常用字文本ToolStripMenuItem_Click(object sender, EventArgs e) {
            _pathOfWordsTxt = "古代汉语常用字前5000.txt";
            Load_wordsTxt();

        }

        private void 选择现代口语常用字ToolStripMenuItem_Click(object sender, EventArgs e) {
            _pathOfWordsTxt = "现代口语常用字前3000.txt";
            Load_wordsTxt();
        }
    }
}
