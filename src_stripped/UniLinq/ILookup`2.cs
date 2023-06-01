// Decompiled with JetBrains decompiler
// Type: UniLinq.ILookup`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

namespace UniLinq
{
  public interface ILookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
  {
    int Count { get; }

    IEnumerable<TElement> this[TKey key] { get; }

    bool Contains(TKey key);
  }
}
