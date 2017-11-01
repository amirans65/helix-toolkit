﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;

namespace HelixToolkit.Wpf.SharpDX.Elements2D
{
    using Core2D;
    public class RectangleModel2D : ShapeModel2D
    {
        protected override ShapeRenderable2DBase CreateShapeRenderCore(IRenderHost host)
        {
            return new RectangleRenderable();
        }
    }
}
