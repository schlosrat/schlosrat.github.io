// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtAtmosphereModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
