// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtRingNearTex
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
  [RequireComponent(typeof (SgtRing))]
  [AddComponentMenu("Space Graphics Toolkit/SGT Ring NearTex")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtRingNearTex")]
  public class SgtRingNearTex : MonoBehaviour
  {
    public int Width;
    public TextureFormat Format;
    public SgtEase.Type Ease;
    public float Sharpness;
    [NonSerialized]
    private Texture2D generatedTexture;
    [NonSerialized]
    private SgtRing cachedRing;
    [NonSerialized]
    private bool cachedRingSet;

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
    public SgtRingNearTex() => throw null;
  }
}
