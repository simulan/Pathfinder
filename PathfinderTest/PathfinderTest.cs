using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathfinderLib;

namespace PathfinderTest {
    [TestClass]
    public class PathfinderTest {
        [TestMethod]
        public void SolveLabyrinthDownwards() {
            Labyrinth labyrinth = new Labyrinth(2, 2, new Cell[] {
                Cell.Start,Cell.Closed,
                Cell.End,Cell.Closed
            });
            PathFinder pf = new PathFinder(labyrinth);
            int[] solution = pf.Solve();
            Assert.IsTrue(solution.Count() != 0);
        }
        [TestMethod]
        public void SolveLabyrinthDownwardsRight() {
            Labyrinth labyrinth = new Labyrinth(4, 4, new Cell[] {
                Cell.Start,Cell.Closed,Cell.Closed,Cell.Closed,
                Cell.Open,Cell.Closed,Cell.Closed,Cell.Closed,
                Cell.Open,Cell.Closed,Cell.Closed,Cell.Closed,
                Cell.Open,Cell.Open,Cell.End,Cell.Closed,
            });
            PathFinder pf = new PathFinder(labyrinth);
            int[] solution = pf.Solve();
            Assert.IsTrue(solution.Count() != 0);
        }
    }
}
