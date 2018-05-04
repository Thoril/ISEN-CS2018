using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Isen.Cs.Library
{
    public interface IMyCollection
    {
        void Add(string item);
        int Count { get; }
        void InsertAt(int index, string item);
        void RemoveAt(int index);
        string[] Values { get; }
    }
}