// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.RuntimePrefabRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class RuntimePrefabRule
  {
    public GameObject RuntimePrefab;
    public float DistanceFactor;
    public float SpawnFrequency;
    public int Seed;
    public bool UsePool;
    public Vector3 PrefabOffset;
    public Vector3 PrefabRotation;
    public Vector3 PrefabScale;
    public LayerMask PrefabLayer;
    public bool UseVegetationItemScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RuntimePrefabRule(RuntimePrefabRule sourceItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RuntimePrefabRule() => throw null;
  }
}
