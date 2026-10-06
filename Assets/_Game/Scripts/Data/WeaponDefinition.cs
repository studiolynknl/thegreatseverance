using UnityEngine;

namespace TheGreatSeverance.Data
{
    public enum WeaponType { Laser, MassDriver, Missile, PointDefense }

    [CreateAssetMenu(menuName = "The Great Severance/Definitions/Weapon", fileName = "Weapon_")]
    public sealed class WeaponDefinition : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private string displayName;
        [SerializeField] private WeaponType weaponType;
        [Min(0f)] [SerializeField] private float range;
        [Min(0f)] [SerializeField] private float damage;
        [Min(0f)] [SerializeField] private float cooldown;
        [Min(0f)] [SerializeField] private float heatGenerated;

        public string Id => id;
        public string DisplayName => displayName;
        public WeaponType Type => weaponType;
        public float Range => range;
        public float Damage => damage;
        public float Cooldown => cooldown;
        public float HeatGenerated => heatGenerated;
    }
}
