namespace Digi21.Math
{
    public interface IDesplazable
    {
        void Offset(Point2D offset);
        void Offset(Point3D offset);
        void Offset(double x, double y);
        void Offset(double x, double y, double z);
    }
}
