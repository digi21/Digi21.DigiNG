namespace Digi21.DigiNG.DigiTab
{
    /// <summary>
    /// Condition under which a <see cref="VertexZAction"/> is applied. When the condition is false, Keep uses
    /// Interpolate, Interpolate uses Keep, CentroidZ uses Keep, and ProjectOnDtm uses Interpolate.
    /// If the polygon has no centroid, CentroidZ applies Keep. If no digital terrain model (DTM) function is available, ProjectOnDtm applies Interpolate.
    /// </summary>
    public enum VertexZCondition
    {
        /// <summary>The action is always applied.</summary>
        Always = 0,
        /// <summary>The action is applied if, at each endpoint, this segment and the adjacent segment have equal X, Y and Z coordinates.</summary>
        IfBothEndpointsMatchAdjacentSegmentsInXyz = 1,
        /// <summary>The action is applied if, at one or both endpoints, this segment and the segment adjacent to that endpoint have equal X, Y and Z coordinates.</summary>
        IfAtLeastOneEndpointMatchesAdjacentSegmentInXyz = 2,
        /// <summary>The action is applied if both nodes receive the Z coordinate of the segment to which this rule applies.</summary>
        IfBothNodesUseCurrentSegmentZ = 3,
    }
}
