﻿// Decompiled with JetBrains decompiler
// Type: RuntimePrefabStorage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RuntimePrefabStorage
{
  [NonSerialized]
  public readonly List<RuntimePrefabInfo> RuntimePrefabInfoList;
  private readonly VegetationItemPool _vegetationItemPool;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RuntimePrefabStorage(VegetationItemPool vegetationItemPool) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetPrefabVisibility(bool value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateFloatingOrigin(Vector3 deltaFloatingOriginOffset) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RemoveRuntimePrefab(int vegetationCellIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddRuntimePrefab(
    GameObject runtimeObject,
    int vegetationCellIndex,
    int vegetationCellItemIndex)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RemoveRuntimePrefab(
    int vegetationCellIndex,
    int vegetationCellItemIndex,
    VegetationItemPool vegetationItemPool)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GameObject GetRuntimePrefab(int vegetationCellIndex, int vegetationCellItemIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DestroyRuntimePrefab(RuntimePrefabInfo runtimePrefabInfo) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Dispose() => throw null;
}
