using System;
using SampleNamespace;

namespace SampleNamespace
{
    class SampleClass { }

    interface ISampleInterface { }

    struct SampleStruct { }

    enum SampleEnum { a, b }

    delegate void SampleDelegate(int i);

    namespace Nested
    {
        class SampleClass2 { }
    }
}

namespace _08命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleNamespace.SampleClass sample1 = new SampleNamespace.SampleClass();
            SampleClass sample2 = new SampleClass();
        }
    }
}
