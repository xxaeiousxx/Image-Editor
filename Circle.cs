using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEditor
{
    public class Circle : IGraphic
    {
        public Circle(Point _location, int _index)
        {
            Location = _location;
            Index = _index;
        }

        public Point Location { get; set; }
        public int Index { get; set; }

        public Label Draw(Action remove)
        {
            Label circle = new Label
            {
                Font = new System.Drawing.Font("Arial", 30),
                Text = "o",
                Location = Location,
                Size = new Size(35, 36),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            circle.Click += (s, e) =>
            {
                if (MessageBox.Show("Remove this circle?", "Confim", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    remove();
                }
            };
            return circle;
        }

        public void Move(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
