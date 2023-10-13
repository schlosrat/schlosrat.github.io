// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtRing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtRing")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Ring")]
  public class SgtRing : MonoBehaviour
  {
    public Color Color;
    public float Brightness;
    public SgtRenderQueue RenderQueue;
    public Texture MainTex;
    public Mesh Mesh;
    public int Segments;
    [Range(0.001f, 0.01f)]
    public float RingEdgeFade;
    public bool Detail;
    public Texture DetailTex;
    public float DetailScaleX;
    public int DetailScaleY;
    public Vector2 DetailOffset;
    public Vector2 DetailSpeed;
    public float DetailTwist;
    public float DetailTwistBias;
    public bool Near;
    public Texture NearTex;
    public float NearDistance;
    public bool Scattering;
    public float ScatteringMie;
    public float ScatteringStrength;
    public bool Lit;
    public Texture LightingTex;
    public Color AmbientColor;
    [SerializeField]
    private List<SgtRingModel> models;
    [NonSerialized]
    private Material material;
    [NonSerialized]
    private bool renderedThisFrame;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAmbientColor(Color value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateMainTex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateNearTex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateLightingTex() => throw null;

    [ContextMenu("Update Material")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateMaterial() => throw null;

    [ContextMenu("Update Mesh")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMesh() => throw null;

    [ContextMenu("Update Models")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateModels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtRing Create(int layer = 0, Transform parent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtRing Create(
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
    protected virtual void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CameraPreRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CameraPostRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SgtRingModel GetOrAddModel(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtRing() => throw null;
  }
}
