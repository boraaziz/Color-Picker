using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace colorPicker
{
    public partial class Form1 : KryptonForm
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonPalette1_PalettePaint(object sender, ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs e)
        {
            this.MaximizeBox = false;
        }
        int r, g, b;
        private void Form1_Load(object sender, EventArgs e)
        {
            vScrollBar1.Value = 250;
            vScrollBar2.Value = 252;
            vScrollBar3.Value = 252;
        }

        private void kontrol_Tick(object sender, EventArgs e)
        {   
            r = vScrollBar1.Value;
            g = vScrollBar2.Value;
            b = vScrollBar3.Value;
            Color darkBg = ControlPaint.Dark(Color.FromArgb(r, g, b));

            if (cdcBox.Checked == true)
            {
                this.BackColor = darkBg;
                label1.ForeColor = Color.FromArgb(250,252,252);
                cdcBox.ForeColor = Color.FromArgb(250, 252, 252);
            }
            else
            {
                this.BackColor = Color.FromArgb(250,252,252);
                label1.ForeColor = Color.Black;
                cdcBox.ForeColor = Color.Black;
            }

            textBox1.BackColor = Color.FromArgb(r, g, b);
            label1.Text = "rgb(" + r + "," + g + "," + b + ")";

            //palet.FormStyles.FormCommon.StateCommon.Back.Color1 = darkBg;
            //palet.FormStyles.FormCommon.StateCommon.Back.Color2 = darkBg;
            //palet.FormStyles.FormCommon.StateCommon.Border.Color1 = darkBg;
            //palet.FormStyles.FormCommon.StateCommon.Border.Color2 = darkBg;
            //palet.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = darkBg;
            //palet.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = darkBg;
            //palet.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = darkBg;
            //palet.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = darkBg;
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            btnKopyala.Text = "Kopyalandı!";
            timerKopya.Enabled = true;
            timerKopya.Start();
            Clipboard.SetText(label1.Text);
        }

        private void timerKopya_Tick(object sender, EventArgs e)
        {
            for (int sayac = 0; sayac <= 7; sayac++)
            {
                btnKopyala.Text = "Kopyala!";
            }

            timerKopya.Stop();
        }

    }
}
