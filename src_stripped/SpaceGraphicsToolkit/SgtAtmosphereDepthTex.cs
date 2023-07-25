// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtAtmosphereDepthTex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Atmosphere DepthTex")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtAtmosphereDepthTex")]
  [RequireComponent(typeof (SgtAtmosphere))]
  [ExecuteInEditMode]
  public class SgtAtmosphereDepthTex : MonoBehaviour
  {
    public int Width;
    public TextureFormat Format;
    public Color HorizonColor;
    public Color InnerColor;
    public SgtEase.Type InnerEase;
    public float InnerColorSharpness;
    public float InnerAlphaSharpness;
    public Color OuterColor;
    public SgtEase.Type OuterEase;
    public float OuterColorSharpness;
    public float OuterAlphaSharpness;
    [NonSerialized]
    private Texture2D generatedInnerTexture;
    [NonSerialized]
    private Texture2D generatedOuterTexture;
    [NonSerialized]
    private SgtAtmosphere cachedAtmosphere;
    [NonSerialized]
    private bool cachedAtmosphereSet;

    public Texture2D GeneratedInnerTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture2D GeneratedOuterTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [ContextMenu("Update Textures")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTextures() => throw null;

    [ContextMenu("Apply Textures")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyTextures() => throw null;

    [ContextMenu("Remove Textures")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTextures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValidateTexture(ref Texture2D texture2D, string createName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WritePixel(
      Texture2D texture2D,
      float u,
      int x,
      Color baseColor,
      SgtEase.Type ease,
      float colorSharpness,
      float alphaSharpness)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtAtmosphereDepthTex() => throw null;
  }
}
