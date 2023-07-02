// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtCloudsphereModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [AddComponentMenu("")]
  [DisallowMultipleComponent]
  [RequireComponent(typeof (MeshFilter))]
  [RequireComponent(typeof (MeshRenderer))]
  public class SgtCloudsphereModel : MonoBehaviour
  {
    public SgtCloudsphere Cloudsphere;
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
    [NonSerialized]
    private List<SgtCloudsphereModel.CameraState> cameraStates;

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
    public static SgtCloudsphereModel Create(SgtCloudsphere cloudsphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Pool(SgtCloudsphereModel model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MarkForDestruction(SgtCloudsphereModel model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtCloudsphereModel() => throw null;

    public class CameraState : SgtCameraState
    {
      public Vector3 LocalPosition;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CameraState() => throw null;
    }
  }
}
