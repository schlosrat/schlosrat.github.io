// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.VegetationItemSelector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Common;
using AwesomeTechnologies.VegetationSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.Utility
{
  public class VegetationItemSelector
  {
    private readonly VisibleVegetationCellSelector _visibleVegetationCellSelector;
    [NonSerialized]
    public readonly List<VegetationCell> ReadyToLoadVegetationCellList;
    [NonSerialized]
    public readonly List<VegetationCell> ReadyToUnloadVegetationCellList;
    [NonSerialized]
    public readonly List<VegetationCell> LoadedVegetationCellList;
    public NativeList<ItemSelectorInstanceInfo> InstanceList;
    public VegetationItemSelector.MultiOnVegetationItemVisibilityChangeDelegate OnVegetationItemVisibleDelegate;
    public VegetationItemSelector.MultiOnVegetationItemVisibilityChangeDelegate OnVegetationItemInvisibleDelegate;
    public VegetationItemSelector.MultiOnVegetationCellVisibilityChangeDelegate OnVegetationCellInvisibleDelegate;
    private NativeList<int> _removeVegetationCellIndexList;
    private NativeList<int> _visibilityChangedIndexList;
    private readonly VegetationSystemPro _vegetationSystemPro;
    public readonly string VegetationItemID;
    private readonly VegetationItemIndexes _vegetationItemIndexes;
    private readonly VegetationCellType _vegetationCellType;
    public float CullingDistance;
    private readonly bool _useSpawnChance;
    private readonly float _spawnChance;
    private readonly int _spawnSeed;
    private bool _useTransformCameras;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemSelector(
      VisibleVegetationCellSelector visibleVegetationCellSelector,
      VegetationSystemPro vegetationSystemPro,
      VegetationItemInfoPro vegetationItemInfoPro,
      bool useSpawnChance,
      float spawnChance,
      int spawnSeed,
      bool useTransformCameras)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnVegetationCellLoaded(VegetationCell vegetationCell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnVegetationCellVisible(VegetationCell vegetationCell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnVegetationCellInvisible(VegetationCell vegetationCell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshVegetationCell(VegetationCell vegetationCell) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshAllVegetationCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle ProcessVisibleCells(JobHandle processCullingHandle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle ProcessInvisibleCells(JobHandle processCullingHandle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle ProcessCulling(JobHandle processCullingHandle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private JobHandle LoadVisibleCells(JobHandle processCullingHandle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private JobHandle RemoveInvisibleCells(JobHandle processCullingHandle) => throw null;

    public delegate void MultiOnVegetationItemVisibilityChangeDelegate(
      ItemSelectorInstanceInfo itemSelectorInstanceInfo,
      VegetationItemIndexes vegetationItemIndexes,
      string vegetationItemID);

    public delegate void MultiOnVegetationCellVisibilityChangeDelegate(int vegetationCellIndex);
  }
}
