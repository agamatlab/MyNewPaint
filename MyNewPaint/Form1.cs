using MyNewPaint.Models;

namespace MyNewPaint
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        public Graphics Graphics { get; set; }
        public Brush Brush { get; set; }
        public Pen Pen { get; set; }


        public Form1()
        {
            InitializeComponent();
            InitializeTools();
        }

        private void InitializeTools()
        {
            bm = new Bitmap(Width, Height);
            Graphics = Graphics.FromImage(bm);

            Brush = new SolidBrush(Color.Black);
            Pen = new Pen(Color.Black, 9);

            this.BackgroundImage = bm;
        }

        Point startLocation;
        Point lastLocation;
        bool isPaint = false;
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            startLocation = e.Location;
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (isPaint)
            {
                isPaint = false;

                var rect = CreateRectangle(startLocation, e.Location);
                ShapeFactory.DrawFactory(currentTool, rect, radio_Brush.Checked ? Brush : Pen, Graphics);
            }

        }

        Rectangle CreateRectangle(Point first, Point second)
        {

            Point startingPoint= new Point(Math.Min(first.X,second.X), Math.Min(first.Y, second.Y));
            Size size = new Size(Math.Abs(first.X - second.X), Math.Abs(first.Y - second.Y));
            return new Rectangle(startingPoint, size);
        }

        string currentTool = string.Empty;
        private void ToolChanged(object sender, EventArgs e)
        {
            currentTool = (sender as Guna.UI2.WinForms.Guna2ImageRadioButton)
                .Tag.ToString() ?? string.Empty;
        } 

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.Location.ToString();
            lastLocation = e.Location;
            if (isPaint)
                this.Refresh();


        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            var result = colorDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                Pen = new Pen(colorDialog.Color, Pen.Width);
                Brush = new SolidBrush(colorDialog.Color);
                pnl_Color.BackColor = colorDialog.Color;
            }
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Pen = new Pen(Pen.Color, (float)num_Size.Value);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Graphics.Clear(Color.White);
            this.Refresh(); 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (isPaint)
            {
                if (lastLocation.X < pnl_ToolBox.Width
                    && lastLocation.Y < pnl_ToolBox.Height)
                {
                    isPaint = false;
                    MessageBox.Show("Can not Exceed Border.");
                    return;
                }
                var rect = CreateRectangle(startLocation, lastLocation);
                ShapeFactory.DrawFactory(currentTool, rect, radio_Brush.Checked ? Brush : Pen, e.Graphics);
                
            }
        }
    }
}