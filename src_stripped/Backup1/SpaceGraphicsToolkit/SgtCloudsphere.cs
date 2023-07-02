// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtCloudsphere
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Cloudsphere")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtCloudsphere")]
  [ExecuteInEditMode]
  public class SgtCloudsphere : MonoBehaviour
  {
    public Color Color;
    public float Brightness;
    public SgtRenderQueue RenderQueue;
    public float Radius;
    public float CameraOffset;
    public Cubemap MainTex;
    public Texture2D DepthTex;
    [Range(0.0f, 1000f)]
    public float Softness;
    public bool Lit;
    public Texture LightingTex;
    public bool Near;
    public Texture NearTex;
    public float NearDistance;
    public bool Detail;
    public Texture DetailTex;
    public float DetailScale;
    public float DetailTiling;
    public Mesh Mesh;
    public float MeshRadius;
    [SerializeField]
    private SgtCloudsphereModel model;
    [NonSerialized]
    private Material material;
    [NonSerialized]
    private bool renderedThisFrame;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColor(Color value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBrightness(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRenderQueue(SgtRenderQueue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRadius(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCameraOffset(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMainTex(Cubemap value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDepthTex(Texture2D value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSoftness(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLit(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLightingTex(Texture value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNear(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNearTex(Texture value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNearDistance(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDetail(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDetailTex(Texture value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDetailScale(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDetailTiling(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMesh(Mesh value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMeshRadius(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDepthTex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateNearTex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLightingTex() => throw null;

    [ContextMenu("Update Material")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMaterial() => throw null;

    [ContextMenu("Update Model")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtCloudsphere Create(int layer = 0, Transform parent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtCloudsphere Create(
      int layer,
      Transform parent,
      Vector3 localPosition,
      Quaternion localRotation,
      Vector3 localScale)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CameraPreCull(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CameraPreRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtCloudsphere() => throw null;
  }
}
