// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.MatrixListPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  [Serializable]
  public class MatrixListPool
  {
    public List<List<Matrix4x4>> PoolList;
    public int MaxCapasity;
    public int CreateCount;
    private List<Matrix4x4> _returnList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MatrixListPool(int poolCount, int capasity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Matrix4x4> GetList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnList(List<Matrix4x4> list) => throw null;
  }
}
