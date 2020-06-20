using System.Collections;

public class Heap<T> where T : IComparer, IEqualityComparer {
    public int Count { get; private set; }

    public Heap() { 
        Count = 0;
    }

    
}