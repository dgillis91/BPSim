﻿using System;
using System.Collections.Generic;
using CustomCollections;

namespace BPSim {
    class Program {
        static void Main(string[] args) {
            int[] data = makeLinearIntegerArray(10);
            Heap<int> heap = new Heap<int>(data);
            
            Console.WriteLine("Initial Heap");
            Console.WriteLine(heap);

            Console.WriteLine("First Extract: {0}", heap.Extract());
            Console.WriteLine(heap);

            Console.WriteLine("Second Extract: {0}", heap.Extract());
            Console.WriteLine(heap);

            Console.WriteLine("Adding Elements:");
            heap.Add(20);
            heap.Add(-3);
            Console.WriteLine(heap);

            Console.WriteLine("Final Length: {0}", heap.Count);
        }

        private static int[] makeLinearIntegerArray(int length) {
            int[] array = new int[length];
            for (int i = 0; i < length; ++i) {
                array[i] = i;
            }
            return array;
        }
    }
}
