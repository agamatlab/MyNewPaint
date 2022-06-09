namespace MyNewPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_ToolBox = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnl_Color = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.num_Size = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radio_Pen = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.radio_Brush = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ImageRadioButton4 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.guna2ImageRadioButton1 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.guna2ImageRadioButton5 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.guna2ImageRadioButton3 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pnl_ToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Size)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ToolBox
            // 
            this.pnl_ToolBox.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ToolBox.Controls.Add(this.pnl_Color);
            this.pnl_ToolBox.Controls.Add(this.btn_Clear);
            this.pnl_ToolBox.Controls.Add(this.num_Size);
            this.pnl_ToolBox.Controls.Add(this.panel2);
            this.pnl_ToolBox.Controls.Add(this.panel1);
            this.pnl_ToolBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ToolBox.FillColor = System.Drawing.Color.White;
            this.pnl_ToolBox.Location = new System.Drawing.Point(0, 0);
            this.pnl_ToolBox.Name = "pnl_ToolBox";
            this.pnl_ToolBox.ShadowColor = System.Drawing.Color.Black;
            this.pnl_ToolBox.Size = new System.Drawing.Size(800, 102);
            this.pnl_ToolBox.TabIndex = 0;
            // 
            // pnl_Color
            // 
            this.pnl_Color.BackColor = System.Drawing.Color.Black;
            this.pnl_Color.BorderColor = System.Drawing.Color.Black;
            this.pnl_Color.BorderThickness = 2;
            this.pnl_Color.Location = new System.Drawing.Point(531, 19);
            this.pnl_Color.Name = "pnl_Color";
            this.pnl_Color.Size = new System.Drawing.Size(60, 58);
            this.pnl_Color.TabIndex = 5;
            this.pnl_Color.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BorderRadius = 15;
            this.btn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(94, 12);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(74, 37);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // num_Size
            // 
            this.num_Size.BackColor = System.Drawing.Color.Transparent;
            this.num_Size.BorderRadius = 15;
            this.num_Size.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_Size.ForeColor = System.Drawing.Color.Black;
            this.num_Size.Location = new System.Drawing.Point(94, 51);
            this.num_Size.Name = "num_Size";
            this.num_Size.Size = new System.Drawing.Size(74, 37);
            this.num_Size.TabIndex = 3;
            this.num_Size.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num_Size.ValueChanged += new System.EventHandler(this.guna2NumericUpDown1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radio_Pen);
            this.panel2.Controls.Add(this.radio_Brush);
            this.panel2.Location = new System.Drawing.Point(606, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 88);
            this.panel2.TabIndex = 1;
            // 
            // radio_Pen
            // 
            this.radio_Pen.CheckedState.Image = global::MyNewPaint.Properties.Resources.pen_60px;
            this.radio_Pen.CheckedState.ImageSize = new System.Drawing.Size(60, 60);
            this.radio_Pen.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.radio_Pen.Image = global::MyNewPaint.Properties.Resources.pen_60px;
            this.radio_Pen.ImageOffset = new System.Drawing.Point(0, 0);
            this.radio_Pen.ImageRotate = 0F;
            this.radio_Pen.ImageSize = new System.Drawing.Size(50, 50);
            this.radio_Pen.Location = new System.Drawing.Point(3, 7);
            this.radio_Pen.Name = "radio_Pen";
            this.radio_Pen.Size = new System.Drawing.Size(92, 78);
            this.radio_Pen.TabIndex = 0;
            // 
            // radio_Brush
            // 
            this.radio_Brush.CheckedState.Image = global::MyNewPaint.Properties.Resources.paintbrush_60px;
            this.radio_Brush.CheckedState.ImageSize = new System.Drawing.Size(60, 60);
            this.radio_Brush.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.radio_Brush.Image = global::MyNewPaint.Properties.Resources.paintbrush_60px;
            this.radio_Brush.ImageOffset = new System.Drawing.Point(0, 0);
            this.radio_Brush.ImageRotate = 0F;
            this.radio_Brush.ImageSize = new System.Drawing.Size(50, 50);
            this.radio_Brush.Location = new System.Drawing.Point(101, 7);
            this.radio_Brush.Name = "radio_Brush";
            this.radio_Brush.Size = new System.Drawing.Size(80, 78);
            this.radio_Brush.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2ImageRadioButton4);
            this.panel1.Controls.Add(this.guna2ImageRadioButton1);
            this.panel1.Controls.Add(this.guna2ImageRadioButton5);
            this.panel1.Controls.Add(this.guna2ImageRadioButton3);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 76);
            this.panel1.TabIndex = 0;
            // 
            // guna2ImageRadioButton4
            // 
            this.guna2ImageRadioButton4.CheckedState.Image = global::MyNewPaint.Properties.Resources.circle_40px;
            this.guna2ImageRadioButton4.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton4.Image = global::MyNewPaint.Properties.Resources.circle_40px;
            this.guna2ImageRadioButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageRadioButton4.ImageRotate = 0F;
            this.guna2ImageRadioButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton4.Location = new System.Drawing.Point(4, 39);
            this.guna2ImageRadioButton4.Name = "guna2ImageRadioButton4";
            this.guna2ImageRadioButton4.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton4.TabIndex = 0;
            this.guna2ImageRadioButton4.Tag = "Circle";
            this.guna2ImageRadioButton4.CheckedChanged += new System.EventHandler(this.ToolChanged);
            // 
            // guna2ImageRadioButton1
            // 
            this.guna2ImageRadioButton1.CheckedState.Image = global::MyNewPaint.Properties.Resources.rhombus_80px;
            this.guna2ImageRadioButton1.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton1.Image = global::MyNewPaint.Properties.Resources.rhombus_80px;
            this.guna2ImageRadioButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageRadioButton1.ImageRotate = 0F;
            this.guna2ImageRadioButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton1.Location = new System.Drawing.Point(40, 39);
            this.guna2ImageRadioButton1.Name = "guna2ImageRadioButton1";
            this.guna2ImageRadioButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton1.TabIndex = 0;
            this.guna2ImageRadioButton1.Tag = "Rhomb";
            this.guna2ImageRadioButton1.CheckedChanged += new System.EventHandler(this.ToolChanged);
            // 
            // guna2ImageRadioButton5
            // 
            this.guna2ImageRadioButton5.CheckedState.Image = global::MyNewPaint.Properties.Resources.triangle_30px;
            this.guna2ImageRadioButton5.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageRadioButton5.Image")));
            this.guna2ImageRadioButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageRadioButton5.ImageRotate = 0F;
            this.guna2ImageRadioButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton5.Location = new System.Drawing.Point(40, 3);
            this.guna2ImageRadioButton5.Name = "guna2ImageRadioButton5";
            this.guna2ImageRadioButton5.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton5.TabIndex = 0;
            this.guna2ImageRadioButton5.Tag = "Triangle";
            this.guna2ImageRadioButton5.CheckedChanged += new System.EventHandler(this.ToolChanged);
            // 
            // guna2ImageRadioButton3
            // 
            this.guna2ImageRadioButton3.CheckedState.Image = global::MyNewPaint.Properties.Resources.rectangle_40px;
            this.guna2ImageRadioButton3.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton3.Image = global::MyNewPaint.Properties.Resources.rectangle_40px;
            this.guna2ImageRadioButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageRadioButton3.ImageRotate = 0F;
            this.guna2ImageRadioButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton3.Location = new System.Drawing.Point(4, 3);
            this.guna2ImageRadioButton3.Name = "guna2ImageRadioButton3";
            this.guna2ImageRadioButton3.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageRadioButton3.TabIndex = 0;
            this.guna2ImageRadioButton3.Tag = "Rectangle";
            this.guna2ImageRadioButton3.CheckedChanged += new System.EventHandler(this.ToolChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_ToolBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.pnl_ToolBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Size)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_ToolBox;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageRadioButton radio_Pen;
        private Guna.UI2.WinForms.Guna2ImageRadioButton radio_Brush;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageRadioButton guna2ImageRadioButton4;
        private Guna.UI2.WinForms.Guna2ImageRadioButton guna2ImageRadioButton3;
        private Guna.UI2.WinForms.Guna2ImageRadioButton guna2ImageRadioButton5;
        private ColorDialog colorDialog;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_Size;
        private Guna.UI2.WinForms.Guna2Button btn_Clear;
        private Guna.UI2.WinForms.Guna2ImageRadioButton guna2ImageRadioButton1;
        private Guna.UI2.WinForms.Guna2Panel pnl_Color;
    }
}