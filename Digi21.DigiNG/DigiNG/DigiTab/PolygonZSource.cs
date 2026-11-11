namespace Digi21.DigiNG.DigiTab
{
    /// <summary>
    /// Source of the Z coordinate of the polygons built by a topology.
    /// </summary>
    public enum PolygonZSource
    {
        /// <summary>The Z coordinate of the centroid.</summary>
        Centroid = 0,
        /// <summary>2.5D: the Z coordinate rules of each code decide the Z of the polygon outline.</summary>
        FromGeometries = 1,
        /// <summary>3D: the Z coordinate of the geometries is kept as it is.</summary>
        FromGeometries3D = 2,
        /// <summary>The Z coordinate is obtained by projecting the outline on a digital terrain model (DTM).</summary>
        ProjectOnDtm = 3,
        /// <summary>The Z coordinate of the highest vertex of each ring.</summary>
        HighestVertex = 4,
    }
}
