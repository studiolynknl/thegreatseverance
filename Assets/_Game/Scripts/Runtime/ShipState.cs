using System;
using System.Collections.Generic;

namespace TheGreatSeverance.Runtime
{
    [Serializable]
    public sealed class ShipState
    {
        public string shipId;
        public string shipDefinitionId;
        public string displayName;
        public float armor;
        public List<ComponentState> components = new();
    }

    [Serializable]
    public sealed class ComponentState
    {
        public string componentDefinitionId;
        public float hitPoints;
        public bool destroyed;
    }
}
