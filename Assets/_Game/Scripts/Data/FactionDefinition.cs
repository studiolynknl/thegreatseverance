using UnityEngine;

namespace TheGreatSeverance.Data
{
    [CreateAssetMenu(menuName = "The Great Severance/Definitions/Faction", fileName = "Faction_")]
    public sealed class FactionDefinition : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private string displayName;
        [TextArea] [SerializeField] private string description;
        [SerializeField] private Sprite emblem;
        [SerializeField] private Color primaryColor = Color.white;

        public string Id => id;
        public string DisplayName => displayName;
        public string Description => description;
        public Sprite Emblem => emblem;
        public Color PrimaryColor => primaryColor;
    }
}
