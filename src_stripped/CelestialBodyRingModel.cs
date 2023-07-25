// Decompiled with JetBrains decompiler
// Type: CelestialBodyRingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Rendering;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (MeshRenderer))]
[ExecuteInEditMode]
[RequireComponent(typeof (MeshFilter))]
public class CelestialBodyRingModel : MonoBehaviour
{
  [NonSerialized]
  private MeshFilter cachedMeshFilter;
  [NonSerialized]
  private bool cachedMeshFilterSet;
  [NonSerialized]
  private MeshRenderer cachedMeshRenderer;
  [NonSerialized]
  private bool cachedMeshRendererSet;
  [NonSerialized]
  private Transform cachedTransform;
  [NonSerialized]
  private bool cachedTransformSet;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static CelestialBodyRingModel Create(CelestialBodyRing ring) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetMesh(Mesh mesh) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetMaterial(Material material) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetRotation(Quaternion rotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MeshRenderer GetRenderer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CelestialBodyRingModel() => throw null;
}
