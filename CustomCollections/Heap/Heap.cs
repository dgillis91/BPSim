using System.Collections.Generic;
using System.Collections;
using System.Text;
using System;

namespace CustomCollections {
    public partial class Heap<T> : System.Collections.Generic.ICollection<T> where T : IComparable {
        private static int DEFAULT_LENGTH = 100;
        
        private int currentLength;
        private T[] data;

        public int Count { get; private set; }
        public bool IsReadOnly { get; private set; } = false;

        public Heap() : this(DEFAULT_LENGTH) { }

        public Heap(int initialLength) {
            currentLength = initialLength;
            Count = 0;
            data = new T[currentLength];
        }

        public Heap(ICollection<T> initialData, int initialLength) :
        this(initialLength >= initialData.Count ? initialLength : initialData.Count) {
            initialData.CopyTo(this.data, 0);
            Count = initialData.Count;
            int maxChildIndex = (int) System.Math.Floor((double) Count / 2);
            for (int i = maxChildIndex; i >= 0; --i) {
                heapify(i);
            }
        }

        public Heap(ICollection<T> initialData) : this(initialData, DEFAULT_LENGTH) { }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < Count; ++i) {
                builder.AppendFormat("{0} ", data[i].ToString());
            }
            return builder.ToString();
        }

        public T extract() {
            if (Count <= 0) {
                throw new EmptyCollectionException("Attempt to extract() from an empty heap");
            }
            T extrema = data[0];
            data[0] = data[--Count];
            heapify(0);
            return extrema;
        }
    }
}