// Decompiled with JetBrains decompiler
// Type: CelestialBodyRingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof (MeshFilter))]
[RequireComponent(typeof (MeshRenderer))]
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
