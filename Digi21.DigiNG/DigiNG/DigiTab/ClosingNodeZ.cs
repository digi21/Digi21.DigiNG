namespace Digi21.DigiNG.DigiTab
{
    /// <summary>
    /// What a topology does when the first and the last vertex of a polygon outline, which are the same point in XY,
    /// have different Z coordinates.
    /// </summary>
    public enum ClosingNodeZ
    {
        /// <summary>The outline is not modified, so it may not close in Z.</summary>
        Unchanged = 0,
        /// <summary>The Z coordinate of the first vertex is written in both vertices.</summary>
        FirstVertex = 1,
        /// <summary>The Z coordinate of the last vertex is written in both vertices.</summary>
        LastVertex = 2,
        /// <summary>The higher of the two Z coordinates is written in both vertices.</summary>
        Highest = 3,
        /// <summary>The lower of the two Z coordinates is written in both vertices.</summary>
        Lowest = 4,
        /// <summary>The average of the two Z coordinates is written in both vertices.</summary>
        Average = 5,
    }
}
