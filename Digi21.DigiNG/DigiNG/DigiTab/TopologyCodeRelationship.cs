namespace Digi21.DigiNG.DigiTab
{
    /// <summary>
    /// How the presence of a code in a ring affects whether the ring forms a polygon.
    /// </summary>
    public enum TopologyCodeRelationship
    {
        /// <summary>The code must be present in the ring for it to form a polygon.</summary>
        Required = 0,
        /// <summary>If the code is present in the ring, the ring forms a polygon.</summary>
        GuaranteesPolygon = 1,
        /// <summary>The presence of the code does not make the ring form a polygon.</summary>
        DoesNotGuaranteePolygon = 2,
        /// <summary>If the code is present in the ring, the ring forms a hole and does not form a polygon.</summary>
        GuaranteesOnlyHoles = 3,
    }
}
