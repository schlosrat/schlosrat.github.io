// Decompiled with JetBrains decompiler
// Type: KSP.AsyncSearchSortFilter.SortOperationData`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace KSP.AsyncSearchSortFilter
{
  public class SortOperationData<T> : AbstractOperationData
  {
    public Comparison<T> comparisonFunction;
    public List<T> inData;
    public KSP.AsyncSearchSortFilter.AsyncSearchSortFilter.AsyncSSFCallback<T> asyncSSFCallback;
    public Mutex mutex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RunOperation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void MakeCallback() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SortOperationData() => throw null;
  }
}
