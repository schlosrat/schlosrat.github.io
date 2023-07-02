// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.ColliderSystem.ColliderSystemPro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Common;
using AwesomeTechnologies.Utility;
using AwesomeTechnologies.VegetationSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.ColliderSystem
{
  [AwesomeTechnologiesScriptOrder(105)]
  [ExecuteInEditMode]
  public class ColliderSystemPro : MonoBehaviour
  {
    public VegetationSystemPro VegetationSystemPro;
    public bool SetBakedCollidersStatic;
    public bool ConvertBakedCollidersToMesh;
    [NonSerialized]
    public VisibleVegetationCellSelector VisibleVegetationCellSelector;
    [NonSerialized]
    public readonly List<VegetationPackageColliderInfo> PackageColliderInfoList;
    public NativeList<JobHandle> JobHandleList;
    public ColliderSystemPro.MultiCreateColliderDelegate OnCreateColliderDelegate;
    public ColliderSystemPro.MultiBeforeDestroyColliderDelegate OnBeforeDestroyColliderDelegate;
    public int CurrentTabIndex;
    public bool ShowDebugCells;
    private Transform _colliderParent;
    public bool ShowColliders;
    private Vector3 _lastFloatingOriginOffset;
    public bool UseColliderQueue;
    public int MaxCollidersPerFrame;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindVegetationSystemPro() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetFloatingOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TestFloatingOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFloatingOrigin(Vector3 deltaFloatingOriginOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCreateCollider(GameObject colliderObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBeforeDestroyCollider(GameObject colliderObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupDelegates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveDelegates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColliderVisibility(bool value) => throw null;

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
    public void SetupColliderSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateColliderParent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyColliderParent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRenderComplete(VegetationSystemPro vegetationSystemPro) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisposeColliderSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetLoadedInstanceCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetVisibleColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BakeCollidersToScene() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BakeVegetationItemColliders(
      ColliderManager colliderManager,
      VegetationItemInfoPro vegetationItemInfoPro)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetNavmeshArea(GameObject go, int navmeshArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmosSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateNavMeshColliderMeshes(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetStatic(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColliderSystemPro() => throw null;

    public delegate void MultiCreateColliderDelegate(GameObject colliderGameObject);

    public delegate void MultiBeforeDestroyColliderDelegate(GameObject colliderGameObject);
  }
}
