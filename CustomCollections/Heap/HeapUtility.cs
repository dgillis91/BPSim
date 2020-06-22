using System;

namespace CustomCollections {
    public partial class Heap<T> : System.Collections.Generic.ICollection<T> where T : IComparable {
        private void heapify(int i) {
            int l, r, largest;
            l = leftChildIndex(i);
            r = rightChildIndex(i);

            if (l < Count && data[l].CompareTo(data[i]) > 0) {
                largest = l;
            } else {
                largest = i;
            }
            if (r < Count && data[r].CompareTo(data[largest]) > 0) {
                largest = r;
            }
            if (largest != i) {
                swapElementsAt(i, largest);
                heapify(largest);
            }
        }

        private static int parentIndex(int index) {
            return (int)System.Math.Floor((double)index / 2);
        }

        private static int leftChildIndex(int index) {
            return 2 * index + 1;
        }

        private static int rightChildIndex(int index) {
            return 2 * index + 2;
        }

        private void swapElementsAt(int i, int j) {
            T temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }
    }
}