namespace Digi21.Math
{
    public struct Segment
    {
        public Segment(Point3D origin, Point3D destination) { throw null; }
        public Point3D Origin { get => throw null; set => throw null; }
        public Point3D Destination { get => throw null; set => throw null; }
        public Point3D DirectionVector => throw null;
        public Window3D Window => throw null;
        public static SegmentRelation AnalyzeRelation(Segment a, Segment b) { throw null; }
        public static SegmentRelation AnalyzeRelationPlaneXY(Segment a, Segment b) { throw null; }
        public static double CalculateAngle(Segment a, Segment b) { throw null; }
        public double Distance(Point3D point) { throw null; }
        public double Distance2D(Point3D point) { throw null; }
        public Point3D Perpendicular(Point3D point) { throw null; }
        public static Point3D Intersection(Segment a, Segment b) { throw null; }
        public double InterpolatedZ(Point2D point) { throw null; }
    }
}
