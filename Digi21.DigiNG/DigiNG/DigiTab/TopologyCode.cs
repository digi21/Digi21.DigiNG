using System.Collections.Generic;

namespace Digi21.DigiNG.DigiTab
{
    /// <summary>
    /// A code that takes part in a topology.
    /// </summary>
    public sealed class TopologyCode
    {
        internal TopologyCode() => throw null;

        /// <summary>Name of the code. It may contain wildcards.</summary>
        public string Name => throw null;

        /// <summary>How the presence of the code in a ring affects whether the ring forms a polygon.</summary>
        public TopologyCodeRelationship Relationship => throw null;

        /// <summary>Python expression whose true result excludes a geometry from the topology. An empty string disables this exclusion condition.</summary>
        public string ExcludeCondition => throw null;

        /// <summary>Priority of the code.</summary>
        public int Priority => throw null;

        /// <summary>Z coordinate rule applied to segments with this code when ZRulesByOtherCode has no entry for the code of the adjacent segment.</summary>
        public TopologyZRule DefaultZRule => throw null;

        /// <summary>
        /// Z coordinate rules used instead of <see cref="DefaultZRule"/> when the segment meets a segment with the code
        /// that is the key of the dictionary.
        /// </summary>
        public IReadOnlyDictionary<string, TopologyZRule> ZRulesByOtherCode => throw null;
    }
}
