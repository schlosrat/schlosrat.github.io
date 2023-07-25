// Decompiled with JetBrains decompiler
// Type: CelestialBodyRingMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Rendering;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class CelestialBodyRingMesh : MonoBehaviour
{
  [NonSerialized]
  private Mesh _generatedMesh;
  [NonSerialized]
  private CelestialBodyRing _cachedRing;
  [NonSerialized]
  private bool _cachedRingSet;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Init(CelestialBodyRing ring) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected virtual void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ApplyMesh() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RemoveMesh() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RegenerateMesh() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CelestialBodyRingMesh() => throw null;
}
