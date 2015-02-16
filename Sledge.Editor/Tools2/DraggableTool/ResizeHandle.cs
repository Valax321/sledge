using System;
using System.Windows.Forms;

namespace Sledge.Editor.Tools2.DraggableTool
{
    public enum ResizeHandle
    {
        TopLeft, Top, TopRight,
        Left, Center, Right,
        BottomLeft, Bottom, BottomRight
    }

    public static class ResizeHandleExtensions
    {
        public static System.Windows.Forms.Cursor GetCursorType(this ResizeHandle handle)
        {
            switch (handle)
            {
                case ResizeHandle.TopLeft:
                    return Cursors.SizeNESW;
                case ResizeHandle.Top:
                    return Cursors.SizeNS;
                case ResizeHandle.TopRight:
                    return Cursors.SizeNWSE;
                case ResizeHandle.Left:
                    return Cursors.SizeWE;
                case ResizeHandle.Center:
                    return Cursors.SizeAll;
                case ResizeHandle.Right:
                    return Cursors.SizeWE;
                case ResizeHandle.BottomLeft:
                    return Cursors.SizeNWSE;
                case ResizeHandle.Bottom:
                    return Cursors.SizeNS;
                case ResizeHandle.BottomRight:
                    return Cursors.SizeNESW;
                default:
                    throw new ArgumentOutOfRangeException("handle");
            }
        }
    }
}