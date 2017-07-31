using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathfinderLib;

namespace PathfinderTest {
    [TestClass]
    public class LabyrinthValidatorTest {
        [TestMethod]
        public void ValidateLabyrinth() {
            Labyrinth l = new Labyrinth(2, 2, new Cell[] {
                Cell.Start,Cell.Closed,
                Cell.End,Cell.Closed
            });
            Assert.IsTrue(LabyrinthValidator.IsValid(l));
        }
        [TestMethod]
        public void ValidateLabyrinthIncorrectSize() {
            Labyrinth l = new Labyrinth(2, 1, new Cell[] {
                Cell.Start,Cell.Closed,
                Cell.End,Cell.Closed
            });
            Assert.IsFalse(LabyrinthValidator.IsValid(l));
        }
        [TestMethod]
        public void ValidateLabyrinthIncorrectCells() {
            Labyrinth l = new Labyrinth(2, 2, new Cell[] {
                Cell.Closed,Cell.Closed,
                Cell.Closed,Cell.Closed
            });
            Assert.IsFalse(LabyrinthValidator.IsValid(l));
        }
    }
}
