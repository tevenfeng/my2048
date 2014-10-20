using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace my2048
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        my2048Core core;
        Bitmap bit = new Bitmap(400, 400);
        my2048MessageBox messageBoxHelp = new my2048MessageBox();

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            messageBoxHelp.messageA = "帮助";
            messageBoxHelp.messageB = "F5:重新开始\r\nF6:截图并保存\r\n↑↓←→：控制方块移动\r\nESC:退出";
            core = new my2048Core();
            core.Reset();
            drow();
            pictureBox_Board.Refresh();
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    messageBoxHelp.ShowDialog();
                    break;
                case Keys.F5:
                    core = new my2048Core();
                    core.Reset();
                    pictureBox_Board.Refresh();
                    break;
                case Keys.F6:
                    my2048ScreenShot();
                    my2048MessageBox mse2 = new my2048MessageBox();
                    mse2.messageA = "截图成功！";
                    mse2.messageB = "保存在" + Directory.GetCurrentDirectory() + "\\成绩截图.bmp";
                    mse2.ShowDialog();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Up:
                    core.Up();
                    if (core.change)
                        core.Add();
                    break;
                case Keys.Down:
                    core.Down();
                    if (core.change)
                        core.Add();
                    break;
                case Keys.Right:
                    core.Right();
                    if (core.change)
                        core.Add();
                    break;
                case Keys.Left:
                    core.Left();
                    if (core.change)
                        core.Add();
                    break;
            }
            drow();
            pictureBox_Board.Refresh();
            label_currentScore.Text = core.grade.ToString();
            if (core.die)
            {
                gameOver();
            }
        }

        private void display(int m, Point dian)
        {
            Graphics gra = Graphics.FromImage(bit);
            switch (m)
            {
                case 0:
                    { gra.FillRectangle(new SolidBrush(Color.BurlyWood), dian.X, dian.Y, 90, 90); } break;
                case 2:
                    { gra.FillRectangle(new SolidBrush(Color.LightSalmon), dian.X, dian.Y, 90, 90); } break;
                case 4:
                    { gra.FillRectangle(new SolidBrush(Color.Peru), dian.X, dian.Y, 90, 90); } break;
                case 8:
                    { gra.FillRectangle(new SolidBrush(Color.Chocolate), dian.X, dian.Y, 90, 90); } break;
                case 16:
                    { gra.FillRectangle(new SolidBrush(Color.Gray), dian.X, dian.Y, 90, 90); } break;
                case 32:
                    { gra.FillRectangle(new SolidBrush(Color.DarkSeaGreen), dian.X, dian.Y, 90, 90); } break;
                case 64:
                    { gra.FillRectangle(new SolidBrush(Color.Gold), dian.X, dian.Y, 90, 90); } break;
                case 128:
                    { gra.FillRectangle(new SolidBrush(Color.HotPink), dian.X, dian.Y, 90, 90); } break;
                case 256:
                    { gra.FillRectangle(new SolidBrush(Color.DarkOrange), dian.X, dian.Y, 90, 90); } break;
                case 512:
                    { gra.FillRectangle(new SolidBrush(Color.LightPink), dian.X, dian.Y, 90, 90); } break;
                case 1024:
                    { gra.FillRectangle(new SolidBrush(Color.DarkRed), dian.X, dian.Y, 90, 90); } break;
                case 2048:
                    { gra.FillRectangle(new SolidBrush(Color.Red), dian.X, dian.Y, 90, 90); } break;
            }
            switch (m)
            {
                case 2:
                case 4:
                case 8:
                    gra.DrawString(m.ToString(), new Font("黑体", 40.5f, FontStyle.Bold), new SolidBrush(Color.White), dian.X + 22, dian.Y + 17);
                    break;
                case 16:
                case 32:
                case 64:
                    gra.DrawString(m.ToString(), new Font("黑体", 40.5f, FontStyle.Bold), new SolidBrush(Color.White), dian.X + 8, dian.Y + 17);
                    break;
                case 128:
                case 256:
                case 512:
                    gra.DrawString(m.ToString(), new Font("黑体", 35.5f, FontStyle.Bold), new SolidBrush(Color.White), dian.X + 0, dian.Y + 20);
                    break;
                case 1024:
                case 2048:
                case 4096:
                case 8192:
                    gra.DrawString(m.ToString(), new Font("黑体", 30.5f, FontStyle.Bold), new SolidBrush(Color.White), dian.X - 4, dian.Y + 23);
                    break;

            }
        }                      //画出一个方块和方块上的数字

        private void drow()
        {
            for (int x = 1; x <= 4; x++)
            {
                for (int y = 1; y <= 4; y++)
                {
                    Point p = new Point(x * 100 - 95, y * 100 - 95);
                    display(core.i[x, y], p);
                }
            }
        }                                          //画出每个方块

        private string bitfile = Directory.GetCurrentDirectory() + "\\成绩截图";//成绩截图的目录

        private void gameOver()
        {
            if (core.bestGrade < core.grade)                                    //判断本次成绩是否刷新纪录
            {
                core.bestGrade = core.grade;
                label_best.Text = core.bestGrade.ToString();
                my2048ScreenShot();
                my2048MessageBox mes3 = new my2048MessageBox();
                mes3.messageA = "恭喜！";
                mes3.messageB = "新的记录！自动为您保存截图。\r\n保存在" + bitfile;
                mes3.ShowDialog();
                core.Reset();
                drow();
                pictureBox_Board.Refresh();

            }
            else
            {
                Game_Over g = new Game_Over();
                g.bg = core.bestGrade;
                g.g = core.grade;
                DialogResult d = g.ShowDialog();
                switch (d)
                {
                    case DialogResult.Retry:
                        core.Reset();
                        drow();
                        pictureBox_Board.Refresh();
                        label_currentScore.Text = core.grade.ToString();
                        label_currentScore.Text = core.bestGrade.ToString();
                        break;
                    case DialogResult.Abort:

                        my2048MessageBox mes2 = new my2048MessageBox();
                        mes2.messageA = "保存成功";
                        mes2.messageB = "保存在" + bitfile;
                        mes2.ShowDialog();
                        core.Reset();
                        drow();
                        pictureBox_Board.Refresh();
                        break;
                    case DialogResult.No:
                        core.Reset();
                        this.Close();
                        break;
                }
            }
        }                                      //游戏结束时需要的操作

        private void my2048ScreenShot()
        {
            Bitmap b = new Bitmap(this.Width, this.Height);
            Graphics gr = Graphics.FromImage(b);
            gr.CopyFromScreen(this.Location, new Point(0, 0), this.Size);
            gr.Dispose();          
            if (!File.Exists(bitfile))  //判断截图是否已存在，如果存在，在路径后面加上一个空格继续保存，避免覆盖
                bitfile += " ";
            b.Save(bitfile + ".bmp");

        }

        private void pictureBox_Board_Paint(object sender, PaintEventArgs e)
        {
            pictureBox_Board.BackgroundImage = bit;
            label_currentScore.Text = core.grade.ToString();
        }
    }
}
