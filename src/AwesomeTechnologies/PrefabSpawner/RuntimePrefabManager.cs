// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.PrefabSpawner.RuntimePrefabManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Common;
using AwesomeTechnologies.Utility;
using AwesomeTechnologies.VegetationStudio;
using AwesomeTechnologies.VegetationSystem;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.PrefabSpawner
{
  public class RuntimePrefabManager
  {
    [NonSerialized]
    public readonly VegetationItemSelector VegetationItemSelector;
    [NonSerialized]
    public readonly RuntimePrefabPool RuntimePrefabPool;
    [NonSerialized]
    public readonly RuntimePrefabStorage RuntimePrefabStorage;
    private readonly VegetationSystemPro _vegetationSystemPro;
    private readonly RuntimePrefabRule _runtimePrefabRule;
    private bool _showPrefabsInHierarchy;
    private VegetationItemInfoPro _vegetationItemInfoPro;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RuntimePrefabManager(
      VisibleVegetationCellSelector visibleVegetationCellSelector,
      VegetationSystemPro vegetationSystemPro,
      VegetationItemInfoPro vegetationItemInfoPro,
      RuntimePrefabRule runtimePrefabRule,
      Transform prefabParent,
      bool showPrefabsInHierarchy,
      QualityManager qualityManager)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRuntimePrefabVisibility(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRuntimePrefabDistance(QualityManager qualityManager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVegetationItemVisible(
      ItemSelectorInstanceInfo itemSelectorInstanceInfo,
      VegetationItemIndexes vegetationItemIndexes,
      string vegetationItemID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVegetationItemInvisible(
      ItemSelectorInstanceInfo itemSelectorInstanceInfo,
      VegetationItemIndexes vegetationItemIndexes,
      string vegetationItemID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVegetationCellInvisible(int vegetationCellIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
