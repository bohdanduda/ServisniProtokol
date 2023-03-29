using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisniProtokol
{
    public partial class PreviewForm : Form
    {
        public PreviewForm()
        {
            InitializeComponent();
        }

        private void pictureBox_preview_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new(Brushes.Black);
            Graphics graphics = e.Graphics;

            graphics.DrawRectangle(p, 10, 10, this.ClientRectangle.Width-45, this.ClientRectangle.Height-60);
            
            graphics.DrawString("Potvrzení o provedení měření", Font, Brushes.Black, 300, 10);
            graphics.DrawString($"Datum měření: {HomePageForm.instance.date.Text}", Font, Brushes.Black, 20, 40);
            graphics.DrawString($"Číslo protokolu: {HomePageForm.instance.protocolNum.Text}", Font, Brushes.Black, 640, 40);

            graphics.DrawRectangle(p, 20, 70, 300, 120); 
            graphics.DrawRectangle(p, 450, 70, 300, 120);

            graphics.DrawString("Zákazník", Font, Brushes.Black, 30,80);
            graphics.DrawString($"Název: {HomePageForm.instance.name.Text}", Font, Brushes.Black, 30, 100);
            graphics.DrawString($"Adresa: {HomePageForm.instance.address.Text}", Font, Brushes.Black, 30, 120);
            graphics.DrawString($"PSČ: {HomePageForm.instance.postNum.Text}", Font, Brushes.Black, 30, 140);
            graphics.DrawString($"IČ: {HomePageForm.instance.id.Text}", Font, Brushes.Black, 30, 160);

            graphics.DrawString("Zařízení", Font, Brushes.Black, 460,80);
            graphics.DrawString($"Výrobce: {HomePageForm.instance.maker.Text}", Font, Brushes.Black, 460, 100);
            graphics.DrawString($"Adresa: {HomePageForm.instance.modelName.Text}", Font, Brushes.Black, 460, 120);
            graphics.DrawString($"PSČ: {HomePageForm.instance.serialNum.Text}", Font, Brushes.Black, 460, 140);

        }
    }
}
