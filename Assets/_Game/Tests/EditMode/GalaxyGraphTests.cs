using NUnit.Framework;
using TheGreatSeverance.Campaign;

namespace TheGreatSeverance.Tests
{
    public sealed class GalaxyGraphTests
    {
        [Test]
        public void CaptureVegaGraph_FindsSolToSiriusThroughVega()
        {
            var graph = CaptureVegaScenario.CreateGraph();
            CollectionAssert.AreEqual(
                new[] { CaptureVegaScenario.Sol, CaptureVegaScenario.Vega, CaptureVegaScenario.Sirius },
                graph.FindPath(CaptureVegaScenario.Sol, CaptureVegaScenario.Sirius));
        }

        [Test]
        public void SolAndCarthage_AreNotDirectlyConnected()
        {
            var graph = CaptureVegaScenario.CreateGraph();
            Assert.IsFalse(graph.AreConnected(CaptureVegaScenario.Sol, CaptureVegaScenario.Carthage));
        }
    }
}
