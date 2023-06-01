// Decompiled with JetBrains decompiler
// Type: KSP.AsyncSearchSortFilter.SearchOperationData`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.AsyncSearchSortFilter
{
  public class SearchOperationData<T> : AbstractOperationData
  {
    public KSP.AsyncSearchSortFilter.AsyncSearchSortFilter.MatchFunctionDelegate<T> MatchFunction;
    public string SearchQuery;
    public List<T> InData;
    public KSP.AsyncSearchSortFilter.AsyncSearchSortFilter.AsyncSSFCallback<T> AsyncSSFCallback;
    public List<T> OutData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RunOperation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void MakeCallback() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SearchOperationData() => throw null;
  }
}
