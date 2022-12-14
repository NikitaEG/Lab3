namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.figuresListBox = new System.Windows.Forms.ListBox();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_change_rect = new System.Windows.Forms.Button();
            this.btn_change_sq = new System.Windows.Forms.Button();
            this.btn_change_el = new System.Windows.Forms.Button();
            this.btn_change_circle = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.move_to_y = new System.Windows.Forms.TextBox();
            this.move_to_x = new System.Windows.Forms.TextBox();
            this.btn_moveAll = new System.Windows.Forms.Button();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_polygon = new System.Windows.Forms.Button();
            this.btn_rocket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 603);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(761, 350);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 33);
            this.btn_delete.TabIndex = 33;
            this.btn_delete.Text = "удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // figuresListBox
            // 
            this.figuresListBox.FormattingEnabled = true;
            this.figuresListBox.ItemHeight = 16;
            this.figuresListBox.Location = new System.Drawing.Point(613, 216);
            this.figuresListBox.Name = "figuresListBox";
            this.figuresListBox.Size = new System.Drawing.Size(142, 388);
            this.figuresListBox.TabIndex = 34;
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(761, 216);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(123, 33);
            this.btn_move.TabIndex = 35;
            this.btn_move.Text = "переместить";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_change_rect
            // 
            this.btn_change_rect.Location = new System.Drawing.Point(761, 423);
            this.btn_change_rect.Name = "btn_change_rect";
            this.btn_change_rect.Size = new System.Drawing.Size(123, 45);
            this.btn_change_rect.TabIndex = 40;
            this.btn_change_rect.Text = "изменить прямоугольник";
            this.btn_change_rect.UseVisualStyleBackColor = true;
            this.btn_change_rect.Click += new System.EventHandler(this.btn_change_rect_Click);
            // 
            // btn_change_sq
            // 
            this.btn_change_sq.Location = new System.Drawing.Point(761, 474);
            this.btn_change_sq.Name = "btn_change_sq";
            this.btn_change_sq.Size = new System.Drawing.Size(123, 42);
            this.btn_change_sq.TabIndex = 41;
            this.btn_change_sq.Text = "изменить квадрат";
            this.btn_change_sq.UseVisualStyleBackColor = true;
            this.btn_change_sq.Click += new System.EventHandler(this.btn_change_sq_Click);
            // 
            // btn_change_el
            // 
            this.btn_change_el.Location = new System.Drawing.Point(761, 522);
            this.btn_change_el.Name = "btn_change_el";
            this.btn_change_el.Size = new System.Drawing.Size(123, 45);
            this.btn_change_el.TabIndex = 42;
            this.btn_change_el.Text = "изменить эллипс";
            this.btn_change_el.UseVisualStyleBackColor = true;
            this.btn_change_el.Click += new System.EventHandler(this.btn_change_el_Click);
            // 
            // btn_change_circle
            // 
            this.btn_change_circle.Location = new System.Drawing.Point(761, 569);
            this.btn_change_circle.Name = "btn_change_circle";
            this.btn_change_circle.Size = new System.Drawing.Size(123, 42);
            this.btn_change_circle.TabIndex = 43;
            this.btn_change_circle.Text = "изменить окружность";
            this.btn_change_circle.UseVisualStyleBackColor = true;
            this.btn_change_circle.Click += new System.EventHandler(this.btn_change_circle_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.Location = new System.Drawing.Point(613, 24);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(142, 42);
            this.btn_rect.TabIndex = 44;
            this.btn_rect.Text = "Прямоугольник";
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_square
            // 
            this.btn_square.Location = new System.Drawing.Point(761, 24);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(123, 42);
            this.btn_square.TabIndex = 45;
            this.btn_square.Text = "Квадрат";
            this.btn_square.UseVisualStyleBackColor = true;
            this.btn_square.Click += new System.EventHandler(this.btn_sq_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.Location = new System.Drawing.Point(613, 72);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(142, 42);
            this.btn_ellipse.TabIndex = 46;
            this.btn_ellipse.Text = "Эллипс";
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.Location = new System.Drawing.Point(761, 72);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(123, 42);
            this.btn_circle.TabIndex = 47;
            this.btn_circle.Text = "Окружность";
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(628, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 20);
            this.label17.TabIndex = 48;
            this.label17.Text = "Создание:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(759, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 25);
            this.label16.TabIndex = 52;
            this.label16.Text = "Y:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(758, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 25);
            this.label15.TabIndex = 51;
            this.label15.Text = "X:";
            // 
            // move_to_y
            // 
            this.move_to_y.Location = new System.Drawing.Point(803, 283);
            this.move_to_y.Name = "move_to_y";
            this.move_to_y.Size = new System.Drawing.Size(81, 22);
            this.move_to_y.TabIndex = 50;
            // 
            // move_to_x
            // 
            this.move_to_x.Location = new System.Drawing.Point(803, 255);
            this.move_to_x.Name = "move_to_x";
            this.move_to_x.Size = new System.Drawing.Size(81, 22);
            this.move_to_x.TabIndex = 49;
            // 
            // btn_moveAll
            // 
            this.btn_moveAll.Location = new System.Drawing.Point(761, 311);
            this.btn_moveAll.Name = "btn_moveAll";
            this.btn_moveAll.Size = new System.Drawing.Size(123, 33);
            this.btn_moveAll.TabIndex = 53;
            this.btn_moveAll.Text = "переместить все";
            this.btn_moveAll.UseVisualStyleBackColor = true;
            this.btn_moveAll.Click += new System.EventHandler(this.btn_moveAll_Click);
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.Location = new System.Drawing.Point(761, 389);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(123, 33);
            this.btn_deleteAll.TabIndex = 54;
            this.btn_deleteAll.Text = "удалить все";
            this.btn_deleteAll.UseVisualStyleBackColor = true;
            this.btn_deleteAll.Click += new System.EventHandler(this.btn_deleteAll_Click);
            // 
            // btn_triangle
            // 
            this.btn_triangle.Location = new System.Drawing.Point(761, 120);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(123, 42);
            this.btn_triangle.TabIndex = 56;
            this.btn_triangle.Text = "Треугольник";
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_polygon
            // 
            this.btn_polygon.Location = new System.Drawing.Point(613, 120);
            this.btn_polygon.Name = "btn_polygon";
            this.btn_polygon.Size = new System.Drawing.Size(142, 42);
            this.btn_polygon.TabIndex = 55;
            this.btn_polygon.Text = "Многоугольник";
            this.btn_polygon.UseVisualStyleBackColor = true;
            this.btn_polygon.Click += new System.EventHandler(this.btn_polygon_Click);
            // 
            // btn_rocket
            // 
            this.btn_rocket.Location = new System.Drawing.Point(613, 168);
            this.btn_rocket.Name = "btn_rocket";
            this.btn_rocket.Size = new System.Drawing.Size(271, 42);
            this.btn_rocket.TabIndex = 57;
            this.btn_rocket.Text = "Сложная фигура";
            this.btn_rocket.UseVisualStyleBackColor = true;
            this.btn_rocket.Click += new System.EventHandler(this.btn_rocket_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 629);
            this.Controls.Add(this.btn_rocket);
            this.Controls.Add(this.btn_triangle);
            this.Controls.Add(this.btn_polygon);
            this.Controls.Add(this.btn_deleteAll);
            this.Controls.Add(this.btn_moveAll);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.move_to_y);
            this.Controls.Add(this.move_to_x);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_circle);
            this.Controls.Add(this.btn_ellipse);
            this.Controls.Add(this.btn_square);
            this.Controls.Add(this.btn_rect);
            this.Controls.Add(this.btn_change_circle);
            this.Controls.Add(this.btn_change_el);
            this.Controls.Add(this.btn_change_sq);
            this.Controls.Add(this.btn_change_rect);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.figuresListBox);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Lab2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox figuresListBox;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_change_rect;
        private System.Windows.Forms.Button btn_change_sq;
        private System.Windows.Forms.Button btn_change_el;
        private System.Windows.Forms.Button btn_change_circle;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox move_to_y;
        private System.Windows.Forms.TextBox move_to_x;
        private System.Windows.Forms.Button btn_moveAll;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_polygon;
        private System.Windows.Forms.Button btn_rocket;
    }
}

