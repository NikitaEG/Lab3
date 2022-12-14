using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;

namespace Lab2
{
    public partial class Form_rocket : Form
    {
        Form1 form_1;
        public Form_rocket(Form1 form_1)
        {
            InitializeComponent();
            this.form_1 = form_1;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(rocket_x.Text);
                int y = int.Parse(rocket_y.Text);
                if (Init.Coords_check(x, y, 100, 200))
                {
                    form_1.rocket_count += 1;
                    Rocket rocket = new Rocket(form_1.rocket_count, x, y, 100, 200);
                    ShapeContainer.AddFigure(rocket);
                    form_1.bs.ResetBindings(false);
                    rocket.Draw();
                }
                else
                {
                    MessageBox.Show("Фигура вышла за границы.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }
    }
}
