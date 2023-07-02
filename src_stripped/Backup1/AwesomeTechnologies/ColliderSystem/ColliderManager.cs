// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.ColliderSystem.ColliderManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Common;
using AwesomeTechnologies.Utility;
using AwesomeTechnologies.VegetationStudio;
using AwesomeTechnologies.VegetationSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.ColliderSystem
{
  public class ColliderManager
  {
    [NonSerialized]
    public readonly VegetationItemSelector VegetationItemSelector;
    [NonSerialized]
    public readonly ColliderPool ColliderPool;
    [NonSerialized]
    public readonly RuntimePrefabStorage RuntimePrefabStorage;
    private readonly VegetationSystemPro _vegetationSystemPro;
    private readonly VegetationItemInfoPro _vegetationItemInfoPro;
    private bool _showColliders;
    public ColliderManager.MultiCreateColliderDelegate OnCreateColliderDelegate;
    public ColliderManager.MultiBeforeDestroyColliderDelegate OnBeforeDestroyColliderDelegate;
    private List<ItemSelectorInstanceInfo> _colliderQueue;
    public int MaxColliderPerFrame;
    public bool UseColliderQueue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColliderManager(
      VisibleVegetationCellSelector visibleVegetationCellSelector,
      VegetationSystemPro vegetationSystemPro,
      VegetationItemInfoPro vegetationItemInfoPro,
      Transform colliderParent,
      bool showColliders,
      QualityManager qualityManager)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColliderVisibility(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateColliderDistance(QualityManager qualityManager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVegetationItemVisible(
      ItemSelectorInstanceInfo itemSelectorInstanceInfo,
      VegetationItemIndexes vegetationItemIndexes,
      string vegetationItemID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateColliderFromQueue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveFromQueue(ItemSelectorInstanceInfo itemSelectorInstanceInfo) => throw null;

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

    public delegate void MultiCreateColliderDelegate(GameObject colliderGameObject);

    public delegate void MultiBeforeDestroyColliderDelegate(GameObject colliderGameObject);
  }
}
