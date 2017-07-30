using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathfinderLib;

namespace PathfinderTest {
    [TestClass]
    public class LabyrinthTest {
        [TestMethod]
        public void CreateLabyrinth() {
            Labyrinth l = new Labyrinth(1, 1, new Cell[] {});
            Assert.IsNotNull(l); 
        }
        [TestMethod]
        public void CreateLabyrinthWithValues() {
            Labyrinth l = new Labyrinth(2, 2, new Cell[] {
                Cell.START,Cell.CLOSED,
                Cell.END,Cell.CLOSED
            });
            Assert.IsNotNull(l);
        }
    }
}
