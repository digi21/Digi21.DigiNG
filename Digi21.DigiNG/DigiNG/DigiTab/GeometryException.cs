using Digi21.Math;
using System;

namespace Digi21.DigiNG.DigiTab
{
    public class GeometryException : Exception
    {
        public GeometryException(string message) => throw null;
        public GeometryException(string message, Point3D coordinates) => throw null;
        public GeometryException(string message, Exception innerException) => throw null;
        public GeometryException(string message, Point3D coordinates, Exception innerException) => throw null;
        public Point3D? Coordinates { get => throw null; set => throw null; }
        public Tuple<string, string>[] ContextualMenuOptions { get => throw null; set => throw null; }
    }
}
