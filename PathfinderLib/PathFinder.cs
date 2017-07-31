using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Move boundary checks to IsFree?
namespace PathfinderLib {
    //DFS
    public class PathFinder {
        Labyrinth labyrinth;
        int[] pathIndices;
        int w;
        int h;
        bool solved;

        public PathFinder(Labyrinth labyrinth) {
            this.labyrinth = labyrinth;
            Initialize();
        }
        private void Initialize() {
            solved = false;
            w = labyrinth.Width;
            h = labyrinth.Height;
            pathIndices = new int[w * h];
        }
        public int[] Solve() {
            int current = getStartIndex();
            AddToPath(current);
            while (!solved) {
                int next = NextOpenPath(current);
                current = next;
                AddToPath(current);
                if (labyrinth.Cells[current] == Cell.End) solved = true;              
            }
            return pathIndices;
        }
        private void AddToPath(int index) {
            pathIndices[index] = 1;
        }
        private int NextOpenPath(int current) {
            if (IsFree(GetTop(current))) {
                return GetTop(current);
            } else if (IsFree(GetRight(current))) {
                return GetRight(current);
            } else if (IsFree(GetDown(current))) {
                return GetDown(current);
            } else if (IsFree(GetLeft(current))) {
                return GetLeft(current);
            } else {
                return -1;
            }
        }

        private int GetTop(int index) {
            int top = index - w;
            if (WithinLabyrinth(top))
                return top;
            else
                return -1;
        }
        private int GetRight(int index) {
            int right = index + 1;
            if (WithinLabyrinth(right) && !AtRightLabyrinthBoundary(index))
                return right;
            else return -1;
        }
        private int GetDown(int index) {
            int down = index + w;
            if (WithinLabyrinth(down))
                return down;
            else return -1;
        }
        private int GetLeft(int index) {
            int left = index - 1;
            if (WithinLabyrinth(left) && !AtLeftLabyrinthBoundary(index))
                return left;
            else return -1;
        }

        private bool WithinLabyrinth(int index) {
            return index > -1 && index < w * h;
        }
        private bool AtRightLabyrinthBoundary(int index) {
            return index % w == w - 1;
        }
        private bool AtLeftLabyrinthBoundary(int index) {
            return index % w == 1;
        }
        private bool IsFree(int index) {
            if (index == -1) return false;
            return IsOpenOrEnd(index) && IsUnexplored(index);
        }
        private bool IsOpenOrEnd(int index) {
            return (labyrinth.Cells[index] == Cell.Open || labyrinth.Cells[index] == Cell.End);
        }
        private bool IsUnexplored(int index) {
            return pathIndices[index]!=1;
        }

        private int getStartIndex() {
            for (int i = 0; i < w * h; i++) {
                if (labyrinth.Cells[i] == Cell.Start) {
                    return i;
                }
            }
            throw new Exception("Labyrinth has no start!");
        }
    }
}
