// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.DeltaVEngineStageSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.DeltaV
{
  public class DeltaVEngineStageSet
  {
    [SerializeField]
    private List<DeltaVStageInfo> _stageInfoEntries;
    [SerializeField]
    internal List<DeltaVEngineInfo> EngineInfoInstance;
    public VesselDeltaVComponent VslDeltaVComponent;
    public List<int> PayloadStages;
    protected IComparer<DeltaVStageInfo> StageSorting;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeltaVEngineStageSet(VesselDeltaVComponent vslDeltaVComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void AddStageInfo(DeltaVStageInfo stageInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateStageInfo(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateStageInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void RemoveStaleStages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetPayload(DeltaVStageInfo stageInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void RemoveStagedStages(bool sortStages = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SortStages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void AddEngine(DeltaVEngineInfo engineInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void RemoveInvalidEngines() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveInvalidEnginesFromSet(ref List<DeltaVEngineInfo> engineInfoList) => throw null;

    public virtual List<DeltaVStageInfo> StageInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public virtual List<DeltaVEngineInfo> EngineInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RemovePart(IGGuid partId) => throw null;

    protected class StageSortingInstance : IComparer<DeltaVStageInfo>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public int Compare(DeltaVStageInfo x, DeltaVStageInfo y) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StageSortingInstance() => throw null;
    }
  }
}
