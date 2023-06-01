// Decompiled with JetBrains decompiler
// Type: KSP.Api.Generic.IListProperty`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
