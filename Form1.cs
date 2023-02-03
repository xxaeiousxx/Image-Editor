using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        public bool willDrawCircle = true;
        public CompoundGraphic MyCompoundGraphic = new CompoundGraphic();

        public Form1()
        {
            InitializeComponent();
        }

        private void BuildComponents()
        {
            panel1.Controls.Clear();
            foreach (IGraphic child in MyCompoundGraphic.children)
            {
                Action remove = () =>
                {
                    MyCompoundGraphic.RemoveChild(child.Index);
                    BuildComponents();
                };
                panel1.Controls.Add(child.Draw(remove));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            willDrawCircle = true;
        }
        private void dotButton_Click(object sender, EventArgs e)
        {
            willDrawCircle = false;
        }

        private void LocateCoordinates(object sender, EventArgs e)
        {
            Point point = panel1.PointToClient(Cursor.Position);
            if (willDrawCircle)
            {
                Circle circle = new Circle(point, MyCompoundGraphic.children.Count);
                MyCompoundGraphic.AddChild(circle);
            }
            else
            {
                Dot dot = new Dot(point, MyCompoundGraphic.children.Count);
                MyCompoundGraphic.AddChild(dot);
            }
            BuildComponents();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            MyCompoundGraphic.children.Clear();
            BuildComponents();
        }
    }
}
