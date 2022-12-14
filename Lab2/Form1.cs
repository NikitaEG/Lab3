using Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public BindingSource bs = new BindingSource();
        public int rect_count = 0;
        public int sq_count = 0;
        public int ellipse_count = 0;
        public int circle_count = 0;
        public int polygon_count = 0;
        public int triangle_count = 0;
        public int rocket_count = 0;
        public Form1()
        {
            InitializeComponent();
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = new Pen(Color.Black, 3);
            Init.pictureBox = pictureBox1;
            Init.figuresListBox = figuresListBox;

            ShapeContainer figure_list = new ShapeContainer();
            bs.DataSource = ShapeContainer.figureList;
            Init.figuresListBox.DataSource = bs;
            Init.figuresListBox.DisplayMember = "Name";
        }
        private void btn_rect_Click(object sender, EventArgs e)
        {
            Form f_rect = new Form_rect(this);
            f_rect.Show();
        }

        private void btn_sq_Click(object sender, EventArgs e)
        {
            Form f_sq = new Form_sq(this);
            f_sq.Show();
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            Form f_ellipse = new Form_ellipse(this);
            f_ellipse.Show();
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            Form f_circle = new Form_circle(this);
            f_circle.Show();
        }
        private void btn_polygon_Click(object sender, EventArgs e)
        {
            Form f_polygon = new Form_polygon(this);
            f_polygon.Show();
        }

        private void btn_triangle_Click(object sender, EventArgs e)
        {
            Form f_triangle = new Form_triangle(this);
            f_triangle.Show();
        }

        private void btn_rocket_Click(object sender, EventArgs e)
        {
            Form f_rocket = new Form_rocket(this);
            f_rocket.Show();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (Init.figuresListBox.SelectedIndex != -1)
            {
                Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                figure.DeleteF(figure, true);
                bs.ResetBindings(false);
            }
        }
        private void btn_deleteAll_Click(object sender, EventArgs e)
        {
            List<Figure> temp = new List<Figure>(ShapeContainer.figureList);
            foreach (Figure f in temp)
            {
                f.DeleteF(f, true);
            }
            bs.ResetBindings(false);
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                if (Init.figuresListBox.SelectedIndex != -1)
                {
                    Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                    if ((figure.ToString() == "Figures.Polygon") || (figure.ToString() == "Figures.Triangle"))
                    {
                        if (Init.Coords_check(figure.points, x, y))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали фигуру.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }
        private void btn_moveAll_Click(object sender, EventArgs e)
        {
            List<Figure> temp = new List<Figure>(ShapeContainer.figureList);
            try
            {
                int x = int.Parse(move_to_x.Text);
                int y = int.Parse(move_to_y.Text);
                foreach (Figure figure in temp)
                {
                    if ((figure.ToString() == "Figures.Polygon") || (figure.ToString() == "Figures.Triangle"))
                    {
                        if (Init.Coords_check(figure.points, x, y))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        if (Init.Coords_check(figure.x + x, figure.y + y, figure.w, figure.h))
                        {
                            figure.MoveTo(x, y);
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }

        private void btn_change_rect_Click(object sender, EventArgs e)
        {
            Form mod_rect = new Mod_rect();
            mod_rect.Show();
        }

        private void btn_change_sq_Click(object sender, EventArgs e)
        {
            Form mod_sq = new Mod_square();
            mod_sq.Show();
        }

        private void btn_change_el_Click(object sender, EventArgs e)
        {
            Form mod_el = new Mod_ellipse();
            mod_el.Show();
        }

        private void btn_change_circle_Click(object sender, EventArgs e)
        {
            Form mod_ci = new Mod_circle();
            mod_ci.Show();
        }
    }
}
