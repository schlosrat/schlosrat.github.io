// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.PrefabSpawner.RuntimePrefabSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Common;
using AwesomeTechnologies.VegetationSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.PrefabSpawner
{
  public class RuntimePrefabSpawner : MonoBehaviour
  {
    public VegetationSystemPro VegetationSystemPro;
    public int CurrentTabIndex;
    public int VegetationPackageIndex;
    private Transform _runtimePrefabParent;
    public bool ShowDebugCells;
    public bool ShowRuntimePrefabs;
    private Vector3 _lastFloatingOriginOffset;
    [NonSerialized]
    public VisibleVegetationCellSelector VisibleVegetationCellSelector;
    [NonSerialized]
    public readonly List<VegetationPackageRuntimePrefabInfo> PackageRuntimePrefabInfoList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindVegetationSystemPro() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshRuntimePrefabs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetFloatingOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TestFloatingOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFloatingOrigin(Vector3 deltaFloatingOriginOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupDelegates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveDelegates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRuntimePrefabVisibility(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClearCache(VegetationSystemPro vegetationSystemPro) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClearCacheVegetationCell(
      VegetationSystemPro vegetationSystemPro,
      VegetationCell vegetationCell)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClearCacheVegetationItem(
      VegetationSystemPro vegetationSystemPro,
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClearCacheVegetationCellVegetationItem(
      VegetationSystemPro vegetationSystemPro,
      VegetationCell vegetationCell,
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRefreshVegetationSystem(VegetationSystemPro vegetationSystemPro) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateCullingDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupRuntimePrefabSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateRuntimePrefabParent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyRuntimePrefabParent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRenderComplete(VegetationSystemPro vegetationSystemPro) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisposeRuntimePrefabSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetLoadedInstanceCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetVisibleColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmosSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RuntimePrefabSpawner() => throw null;
  }
}
