using System;

namespace CustomCollections {
    public partial class Heap<T> : System.Collections.Generic.ICollection<T> where T : IComparable {
        private void Heapify(int i) {
            int l, r, largest;
            l = LeftChildIndex(i);
            r = RightChildIndex(i);

            if (l < Count && data[l].CompareTo(data[i]) > 0) {
                largest = l;
            } else {
                largest = i;
            }
            if (r < Count && data[r].CompareTo(data[largest]) > 0) {
                largest = r;
            }
            if (largest != i) {
                SwapElementsAt(i, largest);
                Heapify(largest);
            }
        }

        private static int ParentIndex(int index) {
            return (int)System.Math.Floor((double)index / 2);
        }

        private static int LeftChildIndex(int index) {
            return 2 * index + 1;
        }

        private static int RightChildIndex(int index) {
            return 2 * index + 2;
        }

        private void SwapElementsAt(int i, int j) {
            T temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
    }
}