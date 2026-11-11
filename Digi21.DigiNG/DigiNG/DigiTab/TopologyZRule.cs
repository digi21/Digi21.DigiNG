namespace Digi21.DigiNG.DigiTab
{
    /// <summary>
    /// Rule that decides the Z coordinates of the nodes and vertices of a segment of a topology.
    /// </summary>
    public sealed class TopologyZRule
    {
        internal TopologyZRule() => throw null;

        /// <summary>Rule applied to the node at the ends of the segment.</summary>
        public NodeZRule NodeRule => throw null;

        /// <summary>Action applied to the intermediate vertices of the segment.</summary>
        public VertexZAction VertexAction => throw null;

        /// <summary>Condition under which <see cref="VertexAction"/> is applied.</summary>
        public VertexZCondition VertexCondition => throw null;

        /// <summary>Tag of the digital terrain models (DTM) used to project nodes and intermediate vertices. An empty DtmTag allows any DTM.</summary>
        public string DtmTag => throw null;
    }
}
