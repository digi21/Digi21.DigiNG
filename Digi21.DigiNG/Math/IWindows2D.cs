
namespace Digi21.Math
{
    public interface IWindow2D
    {
        Point2D W { get; }
        Point2D SW { get; }
        Point2D S { get; }
        Point2D SE { get; }
        Point2D E { get; }
        Point2D NE { get; }
        Point2D N { get; }
        Point2D NW { get; }
        Point2D Center { get; }
        double Height { get; }
        double Width { get; }
        bool Valid { get; }
        double Ymax { get; set; }
        double Xmax { get; set; }
        double Ymin { get; set; }
        double? Xmin { get; set; }
    }
}
