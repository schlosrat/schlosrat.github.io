// Decompiled with JetBrains decompiler
// Type: RuntimePrefabPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AwesomeTechnologies.Utility;
using AwesomeTechnologies.VegetationSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RuntimePrefabPool : VegetationItemPool
{
  private readonly List<GameObject> _prefabPoolList;
  private readonly RuntimePrefabRule _runtimePrefabRule;
  private int _prefabCounter;
  private readonly Transform _prefabParent;
  private bool _showPrefabsInHierarchy;
  private VegetationItemInfoPro _vegetationItemInfoPro;
  private VegetationSystemPro _vegetationSystemPro;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RuntimePrefabPool(
    RuntimePrefabRule runtimePrefabRule,
    VegetationItemInfoPro vegetationItemInfoPro,
    Transform prefabParent,
    bool showPrefabsInHierarchy,
    VegetationSystemPro vegetationSystemPro)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetPrefabVisibility(bool value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddVegetationItemInstanceInfo(GameObject colliderObject) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateVegetationItemInstanceInfo(
    GameObject colliderObject,
    ItemSelectorInstanceInfo info)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override GameObject GetObject(ItemSelectorInstanceInfo info) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GameObject CreateRuntimePrefabObject(ItemSelectorInstanceInfo info) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private HideFlags GetVisibilityHideFlags() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void GetPrefabObjectTransform(
    ItemSelectorInstanceInfo info,
    out Vector3 position,
    out Quaternion rotation,
    out Vector3 localScale)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void ReturnObject(GameObject prefabObject) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void DestroyObject(GameObject go) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Dispose() => throw null;
}
