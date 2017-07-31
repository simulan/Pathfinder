using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLib {
    public static class LabyrinthValidator {
        public static bool IsValid(Labyrinth labyrinth) {
            return (HasValidDimensions(labyrinth) && HasStartAndEnd(labyrinth));
        }
        private static bool HasValidDimensions(Labyrinth labyrinth) {
            int expected = labyrinth.Height * labyrinth.Width;
            return expected == labyrinth.Cells.Count();
        }
        private static bool HasStartAndEnd(Labyrinth labyrinth) {
            int starts = 0;
            int ends = 0;
            foreach (Cell c in labyrinth.Cells) {
                if (c == Cell.Start) starts++;
                if (c == Cell.End) ends++;
            }
            return starts == 1 && ends == 1;
        }
    }
}
