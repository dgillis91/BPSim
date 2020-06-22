using System.Collections.Generic;
using System.Collections;
using System;

namespace CustomCollections {
    public partial class Heap<T> : System.Collections.Generic.ICollection<T> where T : IComparable {
        public void Add(T element) {
            throw new NotImplementedException();
        }

        public void Clear() {
            Count = 0;
            data = new T[DEFAULT_LENGTH];
        }

        public bool Contains(T element) {
            for (int i = 0; i < Count; ++i) {
                if (data[i].Equals(element)) {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex) {
            for (int i = arrayIndex; i < array.Length; ++i) {
                array[i] = data[i - arrayIndex];
            }
        }

        public bool Remove(T item) {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator() {
            for (int i = 0; i < Count; ++i) {
                yield return data[i];
            }
        }
    }
}