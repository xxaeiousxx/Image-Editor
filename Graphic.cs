using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEditor
{
    public interface IGraphic
    {
        void Move(Point point);
        Label Draw(Action remove) { return new Label(); }
        int Index { get; }
    }
}
