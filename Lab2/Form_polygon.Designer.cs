namespace Lab2
{
    partial class Form_polygon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dots_count = new System.Windows.Forms.TextBox();
            this.dot_x = new System.Windows.Forms.TextBox();
            this.dot_y = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите X координату:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите Y координату:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Укажите количество точек:";
            // 
            // dots_count
            // 
            this.dots_count.Location = new System.Drawing.Point(258, 29);
            this.dots_count.Name = "dots_count";
            this.dots_count.Size = new System.Drawing.Size(53, 22);
            this.dots_count.TabIndex = 3;
            // 
            // dot_x
            // 
            this.dot_x.Location = new System.Drawing.Point(225, 67);
            this.dot_x.Name = "dot_x";
            this.dot_x.Size = new System.Drawing.Size(86, 22);
            this.dot_x.TabIndex = 4;
            // 
            // dot_y
            // 
            this.dot_y.Location = new System.Drawing.Point(225, 102);
            this.dot_y.Name = "dot_y";
            this.dot_y.Size = new System.Drawing.Size(86, 22);
            this.dot_y.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Добавить точку";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Enabled = false;
            this.btnDraw.Location = new System.Drawing.Point(182, 138);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(111, 29);
            this.btnDraw.TabIndex = 14;
            this.btnDraw.Text = "Нарисовать";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form_polygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 225);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dot_y);
            this.Controls.Add(this.dot_x);
            this.Controls.Add(this.dots_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_polygon";
            this.Text = "Form_polygon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dots_count;
        private System.Windows.Forms.TextBox dot_x;
        private System.Windows.Forms.TextBox dot_y;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDraw;
    }
}