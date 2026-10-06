using System;
using System.Collections.Generic;

namespace TheGreatSeverance.Campaign
{
    public sealed class GalaxyGraph
    {
        private readonly Dictionary<string, HashSet<string>> adjacency = new();

        public void AddSystem(string systemId)
        {
            if (!adjacency.ContainsKey(systemId))
                adjacency[systemId] = new HashSet<string>();
        }

        public void AddConnection(string a, string b)
        {
            AddSystem(a);
            AddSystem(b);
            adjacency[a].Add(b);
            adjacency[b].Add(a);
        }

        public bool AreConnected(string a, string b) =>
            adjacency.TryGetValue(a, out var neighbors) && neighbors.Contains(b);

        public IReadOnlyCollection<string> GetConnectedSystems(string systemId) =>
            adjacency.TryGetValue(systemId, out var neighbors) ? neighbors : Array.Empty<string>();

        public List<string> FindPath(string start, string goal)
        {
            if (start == goal) return new List<string> { start };
            if (!adjacency.ContainsKey(start) || !adjacency.ContainsKey(goal)) return new List<string>();

            var queue = new Queue<string>();
            var previous = new Dictionary<string, string>();
            var visited = new HashSet<string> { start };
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                foreach (var next in adjacency[current])
                {
                    if (!visited.Add(next)) continue;
                    previous[next] = current;

                    if (next == goal)
                    {
                        var path = new List<string> { goal };
                        var cursor = goal;
                        while (previous.TryGetValue(cursor, out var parent))
                        {
                            path.Add(parent);
                            cursor = parent;
                        }
                        path.Reverse();
                        return path;
                    }

                    queue.Enqueue(next);
                }
            }

            return new List<string>();
        }
    }
}
