using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImageEditor
{
    public class CompoundGraphic : IGraphic
    {
        public CompoundGraphic()
        {
        }

        public List<IGraphic> children = new List<IGraphic>();

        public int Index => 1;

        public void AddChild(IGraphic toAdd)
        {
            children.Add(toAdd);
        }

        public void Move(Point point)
        {
            throw new NotImplementedException();
        }

        public void RemoveChild(int Index)
        {
            children.RemoveAt(Index);
        }

        public Label Draw(Point point)
        {
            throw new NotImplementedException();
        }

    }
}
