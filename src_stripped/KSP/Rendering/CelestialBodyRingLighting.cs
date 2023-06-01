// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyRingLighting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [ExecuteInEditMode]
  public class CelestialBodyRingLighting
  {
    private CelestialBodyRingGroup _cachedGroup;
    [NonSerialized]
    private Texture2D generatedTexture;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(CelestialBodyRingGroup group) => throw null;

    [ContextMenu("Update Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WritePixel(float u, int x) => throw null;

    [ContextMenu("Apply Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyTexture() => throw null;

    [ContextMenu("Remove Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyRingLighting() => throw null;
  }
}
