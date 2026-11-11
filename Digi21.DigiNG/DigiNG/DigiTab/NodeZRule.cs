namespace Digi21.DigiNG.DigiTab
{
    /// <summary>
    /// Z coordinate assigned to a node, which is the shared end of two segments, when the segments have different Z coordinates.
    /// </summary>
    public enum NodeZRule
    {
        /// <summary>The Z coordinate of the segment whose code has the higher priority.</summary>
        HighestPriorityLine = 0,
        /// <summary>The Z coordinate of the segment that has this code.</summary>
        ThisCode = 1,
        /// <summary>The Z coordinate of the other segment.</summary>
        OtherCode = 2,
        /// <summary>The higher Z coordinate of the two segments.</summary>
        HighestZ = 3,
        /// <summary>The lower Z coordinate of the two segments.</summary>
        LowestZ = 4,
        /// <summary>The Z coordinate of the centroid. If the polygon has no centroid, the node receives the Z coordinate of the segment to which this rule applies.</summary>
        CentroidZ = 5,
        /// <summary>
        /// Assigns the Z coordinate of the polygon centroid, or the Z coordinate of the segment to which this rule applies if the polygon has no centroid.
        /// It is the value 6 of the code table, shown as Interpolate in the code table editor.
        /// </summary>
        Interpolate = 6,
        /// <summary>The Z coordinate obtained by projecting the node on a digital terrain model (DTM).</summary>
        ProjectOnDtm = 7,
    }
}
