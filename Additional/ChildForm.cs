using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Additional
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddPolygon(new Point[] {
                new Point(0, this.Height/2),
                new Point(this.Width/2, 0),
                new Point(Width, this.Height/2),
                new Point(this.Width/2, this.Height)
            });

            Region region = new Region(path);
            this.Region = region;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
