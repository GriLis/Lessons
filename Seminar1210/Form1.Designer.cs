namespace Seminar1210
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RectBtn = new System.Windows.Forms.Button();
            this.CircleBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorBtn = new System.Windows.Forms.Button();
            this.trainbtn = new System.Windows.Forms.Button();
            this.vagcount = new System.Windows.Forms.NumericUpDown();
            this.vagbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vagcount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // RectBtn
            // 
            this.RectBtn.Location = new System.Drawing.Point(794, 12);
            this.RectBtn.Name = "RectBtn";
            this.RectBtn.Size = new System.Drawing.Size(140, 29);
            this.RectBtn.TabIndex = 1;
            this.RectBtn.Text = "Прямоугольник";
            this.RectBtn.UseVisualStyleBackColor = true;
            this.RectBtn.Click += new System.EventHandler(this.RectBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.Location = new System.Drawing.Point(794, 47);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(140, 29);
            this.CircleBtn.TabIndex = 2;
            this.CircleBtn.Text = "Круг";
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorBtn.Location = new System.Drawing.Point(794, 231);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(140, 33);
            this.colorBtn.TabIndex = 3;
            this.colorBtn.Text = "Цвет";
            this.colorBtn.UseVisualStyleBackColor = true;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // trainbtn
            // 
            this.trainbtn.Location = new System.Drawing.Point(794, 116);
            this.trainbtn.Name = "trainbtn";
            this.trainbtn.Size = new System.Drawing.Size(93, 29);
            this.trainbtn.TabIndex = 4;
            this.trainbtn.Text = "Поезд";
            this.trainbtn.UseVisualStyleBackColor = true;
            this.trainbtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // vagcount
            // 
            this.vagcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vagcount.Location = new System.Drawing.Point(893, 117);
            this.vagcount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.vagcount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.vagcount.Name = "vagcount";
            this.vagcount.Size = new System.Drawing.Size(41, 26);
            this.vagcount.TabIndex = 5;
            this.vagcount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // vagbtn
            // 
            this.vagbtn.Location = new System.Drawing.Point(794, 81);
            this.vagbtn.Name = "vagbtn";
            this.vagbtn.Size = new System.Drawing.Size(140, 29);
            this.vagbtn.TabIndex = 6;
            this.vagbtn.Text = "Вагон";
            this.vagbtn.UseVisualStyleBackColor = true;
            this.vagbtn.Click += new System.EventHandler(this.vagbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(794, 409);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(140, 29);
            this.clearbtn.TabIndex = 7;
            this.clearbtn.Text = "Очистить";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.vagbtn);
            this.Controls.Add(this.vagcount);
            this.Controls.Add(this.trainbtn);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.CircleBtn);
            this.Controls.Add(this.RectBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Рисование";
            ((System.ComponentModel.ISupportInitialize)(this.vagcount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RectBtn;
        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button trainbtn;
        private System.Windows.Forms.NumericUpDown vagcount;
        private System.Windows.Forms.Button vagbtn;
        private System.Windows.Forms.Button clearbtn;
    }
}

