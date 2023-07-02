// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtRingMainTexFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [RequireComponent(typeof (SgtRing))]
  [ExecuteInEditMode]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtRingMainTexFilter")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Ring MainTex Filter")]
  public class SgtRingMainTexFilter : MonoBehaviour
  {
    public Texture2D Source;
    public TextureFormat Format;
    public float Power;
    [Range(-1f, 1f)]
    public float Exposure;
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

    [ContextMenu("Update Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTexture() => throw null;

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
    private void WritePixel(int x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtRingMainTexFilter() => throw null;
  }
}
