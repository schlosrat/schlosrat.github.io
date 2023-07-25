// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.RuntimePrefabRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
