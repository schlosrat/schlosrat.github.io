// Decompiled with JetBrains decompiler
// Type: KSP.Api.Generic.IListProperty`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

namespace KSP.Api.Generic
{
  public interface IListProperty<T> : 
    IListProperty,
    IList,
    ICollection,
    IEnumerable,
    IList<T>,
    ICollection<T>,
    IEnumerable<T>
  {
    new void RemoveAt(int index);

    new T this[int index] { get; set; }

    new int Count { get; }

    new bool IsReadOnly { get; }

    new void Add(T item);

    new void Clear();

    new bool Contains(T item);

    new void CopyTo(T[] array, int arrayIndex);

    new bool Remove(T item);
  }
}
