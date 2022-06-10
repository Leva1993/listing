using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_01
{
    public partial class Form2 : Form
    {
        const string strTextForButton = "Тестовая строкаааааааааааааа";

        public Form2()
        {
            InitializeComponent();

            button8.Text = strTextForButton;
            using (Graphics graphics = button8.CreateGraphics())
            {
                button8.Width = (int)graphics.MeasureString(strTextForButton,
                Font).Width;
                this.Text = button8.Width.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb.Location = new Point(10, 10);
            tb.Size = new Size(100, 20);
            tb.Text = "Я был создан во время выполнения программы";
            this.Controls.Add(tb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                    ctrl.Text = "Народные советы";
            }
        }

        private void IterateControls(Control ctrl)
        {
            if (ctrl.GetType() == typeof(TextBox))
            {
                ctrl.Text = "Народные советы";
            }

            foreach (Control ctrlChild in ctrl.Controls)
            {
                IterateControls(ctrlChild);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IterateControls(this);
        }

        public class MyButton : Button
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                int borderWidth = 1;
                Color borderColor = Color.Green;
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor,
                borderWidth, ButtonBorderStyle.Solid);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyButton btn = new MyButton();
            btn.Width = 144;
            btn.Height = 23;
            btn.Left = 361;
            btn.Top = 18;
            btn.Text = "Я новая кнопка";
            btn.Visible = true;
            this.Controls.Add(btn);
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 3);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(CheckBox))
                {
                    g.DrawRectangle(p, new Rectangle(ctrl.Location, ctrl.Size));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            const int MAX_LENGTH = 5;
            if (textBox1.Text.Length == MAX_LENGTH)
                SelectNextControl(textBox2, true, true, false, false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Controls.SetChildIndex(button7, 0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();
            // Создадим новый прямоугольник с размерами кнопки
            Rectangle smallRectangle = button9.ClientRectangle;

            // уменьшим размеры прямоугольника
            smallRectangle.Inflate(-3, -3);
            // создадим эллипс, используя полученные размеры
            gp.AddEllipse(smallRectangle);
            button9.Region = new Region(gp);
            // рисуем окантовоку для круглой кнопки
            g.DrawEllipse(new Pen(Color.Gray, 2),
            button9.Left + 1,
            button9.Top + 1,

            button9.Width - 3,
            button9.Height - 3);
            // освобождаем ресурсы
            g.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }
    }
}
