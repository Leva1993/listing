using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_01
{
    public partial class Form3 : Form
    {
        const int EM_GETLINECOUNT = 0x00BA;

        public Form3()
        {
            InitializeComponent();
            ComboBox cboNotDrop = new ComboBox();
            cboNotDrop.Parent = this;
            cboNotDrop.Width = 140;
            cboNotDrop.Height = 60;
            cboNotDrop.Items.Add("One");
            cboNotDrop.Items.Add("Two");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("One");
            listBox1.Items.Add("Two");
            listBox1.Items.Add("Three");
            lstColor.Items.Add(Color.Red.Name);
            lstColor.Items.Add(Color.Yellow.Name);
            lstColor.Items.Add(Color.Green.Name);
            lstColor.Items.Add(Color.Blue.Name);

            txtLinesCount.Multiline = true;
            txtLinesCount.WordWrap = true;
            txtLinesCount.Height = 98;
            txtLinesCount.Text += "У Лукоморья дуб зеленый; ";
            txtLinesCount.Text += "Златая цепь на дубе том: ";
            txtLinesCount.Text += "И днем и ночью кот ученый ";
            txtLinesCount.Text += "Все ходит по цепи кругом";
        }

        private void lstColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) != 0)
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            string itemText = lstColor.Items[e.Index].ToString();
            Color color = Color.FromName(itemText);
            //Рисуем строку
            e.Graphics.DrawString(itemText, Font, new SolidBrush(color),
            e.Bounds);
            Pen pen = new Pen(color);

            //Рисуем линию под строкой
            e.Graphics.DrawLine(pen, e.Bounds.X, e.Bounds.Bottom - 1,
            e.Bounds.Right, e.Bounds.Bottom - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = listBox1.CreateGraphics();
            float maxWidth = 0f;
            float height = 0f;
            for (int i = 0; i < listBox1.Items.Count; ++i)
            {
                float w = g.MeasureString(listBox1.Items[i].ToString(),
                listBox1.Font).Width;
                if (w > maxWidth)
                    maxWidth = w;
                height += listBox1.GetItemHeight(i);
            }
            g.Dispose();
            listBox1.Width = (int)(maxWidth + 8 + ((height > listBox1.Height - 4) ?
             16 : 0));
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            //Извлекаем имя перетаскиваемого файла
            string[] astrings = (string[])e.Data.GetData(DataFormats.FileDrop,
            true);

            foreach (string strfile in astrings)
            {
                // только имя файла
                listBox1.Items.Add(strfile.Substring(1 +
                strfile.LastIndexOf(@"\")));
                // или полный путь к файлу
                listBox1.Items.Add(strfile);
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            // Разрешаем Drop только файлам
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ?
            DragDropEffects.All : DragDropEffects.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = comboBox1.CreateGraphics();
            float maxWidth = 0f;
            foreach (object o in comboBox1.Items)
            {
                float w = g.MeasureString(o.ToString(), comboBox1.Font).Width;
                if (w > maxWidth)
                    maxWidth = w;
            }
            g.Dispose();
            // 28 - учитываем ширину кнопки в поле со списком
            comboBox1.Width = (int)maxWidth + 28;
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // константы для левой кнопки мыши
            const int WM_LBUTTONDOWN = 0x201;
            const int WM_LBUTTONDBLCLK = 0x203;
            if (m.Msg == WM_LBUTTONDOWN || m.Msg == WM_LBUTTONDBLCLK)
                return;
            base.WndProc(ref m);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Font = new Font("Arial", 16);
        }

        public static extern IntPtr SendMessage01(IntPtr hWnd, UInt32 Msg, Int32 wParam, UInt32 lParam);

        public static extern int SendMessage02(IntPtr hWnd, UInt32 Msg, UInt32 wParam, UInt32 lParam);

        private void button7_Click(object sender, EventArgs e)
        {
            const int CB_SETITEMHEIGHT = 0x0153;
            SendMessage01(comboBox1.Handle, CB_SETITEMHEIGHT, -1, 40);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int LineCount;
            LineCount = SendMessage02(txtLinesCount.Handle, EM_GETLINECOUNT, 0, 0);
            MessageBox.Show("Число строк: " + LineCount);
        }
    }
}
