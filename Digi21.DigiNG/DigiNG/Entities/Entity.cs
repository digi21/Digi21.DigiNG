﻿using Digi21.DigiNG.IO;
using Digi21.Math;
using System;
using System.Collections.Generic;

namespace Digi21.DigiNG.Entities
{
    public abstract class Entity : IWindow3D, ICloneable
    {
        public Entity Clone() => throw null;
        #region ICloneable
        object ICloneable.Clone() => throw null;
        #endregion
        public override string ToString() => throw null;
        #region IWindow3D
        public Point3D W => throw null;
        public Point3D SW => throw null;
        public Point3D S => throw null;
        public Point3D SE => throw null;
        public Point3D E => throw null;
        public Point3D NE => throw null;
        public Point3D N => throw null;
        public Point3D NW => throw null;
        public Point3D Center => throw null;
        public double Depth => throw null;
        public double Height => throw null;
        public double Width => throw null;
        public bool Valid => throw null;
        public double Zmax => throw null;
        public double Ymax => throw null;
        public double Xmax => throw null;
        public double Zmin => throw null;
        public double Ymin => throw null;
        public double? Xmin => throw null;
        #endregion
        public IDrawingFile Owner => throw null;
        public IDictionary<string, object> Attributes { get => throw null; set => throw null; }

        public bool Deleted => throw null;
        public bool ReadOnly => throw null;
        public int? FillColor { get => throw null; set => throw null; }
        public int? Weight { get => throw null; set => throw null; }
        public int? Color { get => throw null; set => throw null; }
        public IList<Code> Codes => throw null;
        public bool Visible => throw null;
        public bool Hidden { get => throw null; set => throw null; }
        public DateTime CreationTime => throw null;
        public string FilePointer => throw null;
        public object UserData { get => throw null; set => throw null; }
    }
}
