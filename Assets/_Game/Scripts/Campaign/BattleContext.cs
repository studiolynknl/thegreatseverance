using TheGreatSeverance.Runtime;

namespace TheGreatSeverance.Campaign
{
    public sealed class BattleContext
    {
        public string systemId;
        public FleetState attacker;
        public FleetState defender;
    }

    public static class BattleContextStore
    {
        public static BattleContext Current { get; private set; }

        public static void Set(BattleContext context) => Current = context;
        public static void Clear() => Current = null;
    }
}
