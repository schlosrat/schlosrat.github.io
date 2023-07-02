// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABPartSearchQueryRunner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
