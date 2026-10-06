using UnityEngine;

namespace TheGreatSeverance.Data
{
    public enum ShipClass { Escort, Strike, Capital, Heavy }

    [CreateAssetMenu(menuName = "The Great Severance/Definitions/Ship", fileName = "Ship_")]
    public sealed class ShipDefinition : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private string displayName;
        [SerializeField] private FactionDefinition faction;
        [SerializeField] private ShipClass shipClass;
        [SerializeField] private GameObject tacticalPrefab;
        [SerializeField] private Sprite icon;
        [Min(1f)] [SerializeField] private float maxArmor = 100f;

        public string Id => id;
        public string DisplayName => displayName;
        public FactionDefinition Faction => faction;
        public ShipClass Class => shipClass;
        public GameObject TacticalPrefab => tacticalPrefab;
        public Sprite Icon => icon;
        public float MaxArmor => maxArmor;
    }
}
