// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABPartSearchQueryRunner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class OABPartSearchQueryRunner
  {
    private HashSet<OABPartSearchQueryRunner.PartSearchTermEvaluator> partTermEvaluators;
    private SearchQueryRunner searchHelper;
    private string lastSearchQuery;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSearchTermEvaluators(
      params OABPartSearchQueryRunner.PartSearchTermEvaluator[] partTermEvaluators)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveSearchTermEvaluators(
      params OABPartSearchQueryRunner.PartSearchTermEvaluator[] partTermEvaluators)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearSearchTermEvaluators() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Evaluate(
      string searchQuery,
      IEnumerable<IObjectAssemblyAvailablePart> parts,
      OABPartSearchQueryRunner.PartSearchAction onHit,
      OABPartSearchQueryRunner.PartSearchAction onMiss)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABPartSearchQueryRunner() => throw null;

    public delegate bool PartSearchTermEvaluator(
      IObjectAssemblyAvailablePart part,
      string searchTerm);

    public delegate void PartSearchAction(IObjectAssemblyAvailablePart part);
  }
}
