using UnityEngine;

namespace TheGreatSeverance.Data
{
    public enum ShipComponentType { Reactor, Engine, Radiator, Sensor, Command, Magazine, Weapon }

    [CreateAssetMenu(menuName = "The Great Severance/Definitions/Ship Component", fileName = "Component_")]
    public sealed class ShipComponentDefinition : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private string displayName;
        [SerializeField] private ShipComponentType type;
        [Min(1f)] [SerializeField] private float maxHitPoints = 100f;

        public string Id => id;
        public string DisplayName => displayName;
        public ShipComponentType Type => type;
        public float MaxHitPoints => maxHitPoints;
    }
}
