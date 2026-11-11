using System;
using System.Collections.Generic;

namespace Digi21.DigiNG.DigiTab
{
    /// <summary>
    /// Definition of a topology stored in a code table.
    /// </summary>
    /// <remarks>
    /// The properties are a copy of the data of the code table taken when the object was created.
    /// The TopologyDefinition instance retains references to the native definition and native code table until TopologyDefinition.Dispose is called.
    /// </remarks>
    public sealed class TopologyDefinition : IDisposable
    {
        internal TopologyDefinition() => throw null;
        public void Dispose() => throw null;

        /// <summary>Name of the topology.</summary>
        public string Name => throw null;

        /// <summary>Submenu of the topology menu where the topology is shown.</summary>
        public string Submenu => throw null;

        /// <summary>Code assigned to the polygons built by the topology.</summary>
        public string PolygonCode => throw null;

        /// <summary>Source of the Z coordinate of the polygons.</summary>
        public Digi21.DigiNG.DigiTab.PolygonZSource PolygonZSource => throw null;

        /// <summary>What is done when the first and the last vertex of a polygon outline have different Z coordinates.</summary>
        public Digi21.DigiNG.DigiTab.ClosingNodeZ ClosingNodeZ => throw null;

        /// <summary>Tag of the digital terrain models (DTM) the polygons are projected on. Only used with <see cref="Digi21.DigiNG.DigiTab.PolygonZSource.ProjectOnDtm"/>. Empty means any DTM.</summary>
        public string DtmTag => throw null;

        /// <summary>True if the topology only forms polygons that have 3D continuity.</summary>
        public bool Requires3DContinuity => throw null;

        /// <summary>When ReportPolygonsWithoutCentroid is true, topology generation reports polygons without a centroid as errors; when the property is false, topology generation ignores those polygons.</summary>
        public bool ReportPolygonsWithoutCentroid => throw null;

        /// <summary>Text of the centroid that declares that the polygon is a hole.</summary>
        public string HoleCentroidText => throw null;

        /// <summary>True if topology generation copies the table and record from the centroid to the polygon.</summary>
        public bool CopyTableAndRecordFromCentroid => throw null;

        /// <summary>True if topology generation copies the database attributes from the centroid to the polygon.</summary>
        public bool CopyDatabaseAttributesFromCentroid => throw null;

        /// <summary>Fill color of the polygons without centroid.</summary>
        public string FillColorWithoutCentroid => throw null;

        /// <summary>Fill color of the polygons whose centroid text is not defined in <see cref="Centroids"/>.</summary>
        public string FillColorUnknownCentroid => throw null;

        /// <summary>Codes that take part in the topology.</summary>
        public IReadOnlyList<TopologyCode> Codes => throw null;

        /// <summary>Centroids defined by the topology.</summary>
        public IReadOnlyList<TopologyCentroid> Centroids => throw null;
    }
}
