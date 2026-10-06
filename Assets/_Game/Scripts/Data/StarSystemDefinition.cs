using UnityEngine;

namespace TheGreatSeverance.Data
{
    [CreateAssetMenu(menuName = "The Great Severance/Definitions/Star System", fileName = "System_")]
    public sealed class StarSystemDefinition : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private string displayName;
        [SerializeField] private Vector2 mapPosition;
        [SerializeField] private long basePopulation;
        [SerializeField] private int baseIndustry;
        [SerializeField] private Sprite icon;

        public string Id => id;
        public string DisplayName => displayName;
        public Vector2 MapPosition => mapPosition;
        public long BasePopulation => basePopulation;
        public int BaseIndustry => baseIndustry;
        public Sprite Icon => icon;
    }
}
