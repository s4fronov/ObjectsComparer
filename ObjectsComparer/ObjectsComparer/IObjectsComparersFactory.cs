using System;

namespace ObjectsComparer
{
    public interface IObjectsComparersFactory
    {
        IObjectsDataComparer GetObjectsComparer(Type type, ComparisonSettings settings = null, IObjectsDataComparer parentComparer = null);

        IObjectsDataComparer GetObjectsComparer<T>(ComparisonSettings settings = null, IObjectsDataComparer parentComparer = null);
    }
}