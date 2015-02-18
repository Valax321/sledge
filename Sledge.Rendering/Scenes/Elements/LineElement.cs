﻿using System.Collections.Generic;
using System.Drawing;
using Sledge.Rendering.Cameras;

namespace Sledge.Rendering.Scenes.Elements
{
    public class LineElement : Element
    {
        public float Width { get; set; }
        public Color Color { get; private set; }
        public List<Position> Vertices { get; set; }

        public LineElement(Color color, List<Position> vertices)
        {
            Color = color;
            Vertices = vertices;
            Width = 1; // todo change line widths?
            CameraFlags = CameraFlags.All;
        }
    }
}