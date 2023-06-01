// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtAtmosphereModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [AddComponentMenu("")]
  [RequireComponent(typeof (MeshFilter))]
  [RequireComponent(typeof (MeshRenderer))]
  public class SgtAtmosphereModel : MonoBehaviour
  {
    public SgtAtmosphere Atmosphere;
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
    public void SetMesh(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMaterial(Material material) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Restore(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtAtmosphereModel Create(SgtAtmosphere atmosphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Pool(SgtAtmosphereModel outer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MarkForDestruction(SgtAtmosphereModel outer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtAtmosphereModel() => throw null;
  }
}
