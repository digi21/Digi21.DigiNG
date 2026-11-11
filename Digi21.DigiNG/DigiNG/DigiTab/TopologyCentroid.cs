using System;
using System.Collections.Generic;

namespace Digi21.DigiNG.DigiTab
{
    /// <summary>
    /// Text or prefix used to identify a centroid, with the settings applied to polygons that contain a matching centroid.
    /// </summary>
    public sealed class TopologyCentroid
    {
        internal TopologyCentroid() => throw null;

        /// <summary>Text of the centroid, or its prefix if <see cref="IsPrefix"/> is true.</summary>
        public string Text => throw null;

        /// <summary>True if <see cref="Text"/> is a prefix: any text defined by the user that starts with it matches.</summary>
        public bool IsPrefix => throw null;

        /// <summary>Description of the centroid.</summary>
        public string Description => throw null;

        /// <summary>Fill color of the polygons that contain this centroid.</summary>
        public string FillColor => throw null;

        /// <summary>Source of the Z coordinate of the polygon. When this property is null, the polygon uses the Z source specified by TopologyDefinition.PolygonZSource.</summary>
        public PolygonZSource? PolygonZSource => throw null;

        /// <summary>Values (field name and value) that the polygon takes from this centroid.</summary>
        public IReadOnlyDictionary<string, string> FieldValues => throw null;
    }
}
