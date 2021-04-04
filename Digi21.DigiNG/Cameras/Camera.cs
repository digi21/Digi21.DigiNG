using Digi21.Math;

namespace Digi21.DigiNG.Cameras
{
    public abstract class Camera
    {
        public override string ToString() => throw null;
        public Point3D ViewportToWorld(Point3D viewport) => throw null;
        public Point3D WorldToViewport(Point3D world) => throw null;

        public double Far { get => throw null; set => throw null; }
        public double Near { get => throw null; set => throw null; }
        public double Roll { get => throw null; set => throw null; }
        public double Heading { get => throw null; set => throw null; }
        public double Pitch { get => throw null; set => throw null; }
        public Point3D Position { get => throw null; set => throw null; }
        public string Name { get => throw null; set => throw null; }
    }
}
