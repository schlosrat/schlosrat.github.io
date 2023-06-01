// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtCloudsphereNearTex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Cloudsphere NearTex")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtCloudsphereNearTex")]
  [RequireComponent(typeof (SgtCloudsphere))]
  [ExecuteInEditMode]
  public class SgtCloudsphereNearTex : MonoBehaviour
  {
    public int Width;
    public TextureFormat Format;
    public SgtEase.Type Ease;
    public float Sharpness;
    [Range(0.0f, 1f)]
    public float Offset;
    [NonSerialized]
    private Texture2D generatedTexture;
    [NonSerialized]
    private SgtCloudsphere cachedCloudsphere;
    [NonSerialized]
    private bool cachedCloudsphereSet;

    public Texture2D GeneratedTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [ContextMenu("Update Textures")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTextures() => throw null;

    [ContextMenu("Apply Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyTexture() => throw null;

    [ContextMenu("Remove Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WritePixel(float u, int x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtCloudsphereNearTex() => throw null;
  }
}
