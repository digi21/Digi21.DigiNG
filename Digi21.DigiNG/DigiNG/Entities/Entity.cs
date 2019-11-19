using Digi21.DigiNG.IO;
using Digi21.Math;
using System;

namespace Digi21.DigiNG.Entities
{
    public abstract class Entity : IWindow3D, ICloneable, IDisposable
    {
        public virtual Entity Clone() { throw null; }
        object ICloneable.Clone() { throw null; }
        public virtual void Dispose() { throw null; }
        public override string ToString() { throw null; }
        public Point3D W { get; }
        public Point3D SW { get; }
        public Point3D S { get; }
        public Point3D SE { get; }
        public Point3D E { get; }
        public Point3D NE { get; }
        public Point3D N { get; }
        public Point3D NW { get; }
        public Point3D Center { get; }
        public double Depth { get; }
        public double Height { get; }
        public double Width { get; }
        public bool Valid { get; }
        public double Zmax { get; set; }
        public double Ymax { get; set; }
        public double Xmax { get; set; }
        public double Zmin { get; set; }
        public double Ymin { get; set; }
        public double? Xmin { get; set; }
        public IDrawingFile Owner { get; }
        public bool Deleted { get; }
        public bool ReadOnly { get; }
        public int? FillColor { get; set; }
        public int? Weight { get; set; }
        public int? Color { get; set; }
        public CodeCollection Codes { get; }
        public bool Visible { get; }
        public DateTime CreationTime { get; }
        public int Offset { get; }
    }
}
