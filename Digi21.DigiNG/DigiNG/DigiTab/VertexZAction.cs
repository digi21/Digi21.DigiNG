namespace Digi21.DigiNG.DigiTab
{
    /// <summary>
    /// What a topology does with the Z coordinate of the intermediate vertices of a segment, those that are not nodes.
    /// </summary>
    public enum VertexZAction
    {
        /// <summary>The vertex keeps its own Z coordinate.</summary>
        Keep = 0,
        /// <summary>The Z coordinate is interpolated linearly between the two nodes of the segment.</summary>
        Interpolate = 1,
        /// <summary>The Z coordinate of the centroid of the polygon.</summary>
        CentroidZ = 2,
        /// <summary>The Z coordinate given by the digital terrain model (DTM) at the XY of the vertex.</summary>
        ProjectOnDtm = 3,
    }
}
