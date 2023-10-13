// Decompiled with JetBrains decompiler
// Type: ColliderPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AwesomeTechnologies.Utility;
using AwesomeTechnologies.VegetationSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ColliderPool : VegetationItemPool
{
  private readonly List<GameObject> _colliderPoolList;
  private readonly VegetationItemInfoPro _vegetationItemInfoPro;
  private readonly VegetationItemModelInfo _vegetationItemModelInfo;
  private readonly VegetationSystemPro _vegetationSystemPro;
  private int _colliderCounter;
  private readonly Transform _colliderParent;
  private readonly GameObject _sourceColliderObject;
  private bool _showColliders;
  private LayerMask _colliderLayer;
  private string _colliderTag;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ColliderPool(
    VegetationItemInfoPro vegetationItemInfoPro,
    VegetationItemModelInfo vegetationItemModelInfo,
    VegetationSystemPro vegetationSystemPro,
    Transform colliderParent,
    bool showColliders)
  {
    throw null;
  }

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
  public void SetColliderVisibility(bool value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override GameObject GetObject(ItemSelectorInstanceInfo info) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private HideFlags GetVisibilityHideFlags() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PositionColliderObject(GameObject colliderObject, ItemSelectorInstanceInfo info) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GameObject CreateColliderObject(ItemSelectorInstanceInfo info) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private GameObject CreatePrimitiveCollider(ItemSelectorInstanceInfo info) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddNavMesObstacle(GameObject go) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void ReturnObject(GameObject colliderObject) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private GameObject CreateColliderObject(GameObject sourceObject) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void DestroyObject(GameObject go) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Dispose() => throw null;
}
