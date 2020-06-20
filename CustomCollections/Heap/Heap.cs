using System.Collections;

namespace CustomCollections.Heap {
    public class Heap<T> where T : IComparer, IEqualityComparer {
        private static const int DEFAULT_LENGTH = 100;
        
        private int currentLength;
        private T[] data;

        public int Count { get; private set; }

        public Heap() { 
            Heap(Heap.DEFAULT_LENGTH);
        }

        public Heap(int initialLength) {
            Count = 0;
            currentLength = initialLength;
            data = new int[currentLength];
        }

        public Heap(ICollection<T> initialData, int initialLength) {
            if (initialLength >= initialData.Count) {
                Heap(initialLength);
            } else {
                Heap(initialData.Count);
            }
            initialData.CopyTo(this.data, 0);
            Count = initialData.Count;
            //maxHeapify(); BUILD MAX HEAP
        }

        public Heap(ICollection<T> initialData) {
            Heap(initialData, Heap.DEFAULT_LENGTH);
        }

        private void maxHeapify(int i) {
            
        }

        private static int parentIndex(int index) {
            return Math.floor(index / 2);
        }

        private static int leftChildIndex(int index) {
            return 2 * index;
        }

        private static int rightChildIndex(int index) {
            return 2 * index + 1;
        }
    }
}