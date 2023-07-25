// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.ListPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.Utility
{
  [Serializable]
  public class ListPool<T>
  {
    public List<List<T>> PoolList;
    public int MaxCapasity;
    public int CreateCount;
    private List<T> _returnList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ListPool(int poolCount, int capasity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<T> GetList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnList(List<T> list) => throw null;
  }
}
