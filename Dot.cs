using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEditor
{
    public class Dot : IGraphic
    {

        public Dot(Point _location, int _index)
        {
            Location = _location;
            Index = _index;
        }

        public Point Location { get; set; }
        public int Index { get; set; }


        public Label Draw(Action remove)
        {
            Label dot = new Label
            {
                Font = new Font("Arial", 15),
                Text = ".",
                Location = Location,
                Size = new Size(50, 50),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            dot.Click += (s, e) =>
            {
                if (MessageBox.Show("Remove this dot?", "Confim", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    remove();
                }
            };
            return dot;
        }

        public void Move(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
