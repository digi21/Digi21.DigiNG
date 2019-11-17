using Digi21.Math;

namespace Digi21.DigiNG.Cameras
{
    public abstract class Camera
    {
        public override string ToString() { throw null; }
        public Point3D ViewportToWorld(Point3D viewport) { throw null; }
        public Point3D WorldToViewport(Point3D world) { throw null; }

        public double Far { get; set; }
        public double Near { get; set; }
        public double Roll { get; set; }
        public double Heading { get; set; }
        public double Pitch { get; set; }
        public Point3D Position { get; set; }
        public string Name { get; set; }
    }
}
