using Digi21.DigiNG.Entities;
using Digi21.Math;

namespace Digi21.DigiNG.QualityControl
{
    public class GeometricRelationException : GeometryException
    {
        public GeometricRelationException(Entity entity, string message) : base(string.Empty) => throw null;
        public GeometricRelationException(Entity entity, Point3D coordinates, string message) : base(string.Empty) => throw null;
        public GeometricRelationException(Entity entity, string message, GeometryException innerException) : base(string.Empty) => throw null;
        public GeometricRelationException(Entity entity, Point3D coordinates, string message, GeometryException innerException) : base(string.Empty) => throw null;
        public Entity Entity { get => throw null; set => throw null; }
    }
}
