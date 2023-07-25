// Decompiled with JetBrains decompiler
// Type: RenderTextureHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class RenderTextureHelper
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void DisposeRenderTexture(RenderTexture texture) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void ClearCubemapArray(RenderTexture[] cubemap) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Clear(RenderTexture rt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CopyCubemapArray(RenderTexture[] source, ref RenderTexture[] dest) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SafeCopyTexture(RenderTexture source, ref RenderTexture dest) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SafeCopyTextureToCubemapFace(
    RenderTexture source,
    ref RenderTexture dest,
    int face)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static RenderTexture CreateCubemapRenderTexture(string name, int res, bool useMipMap = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static RenderTexture CreateRenderTexture(string name, int res, bool useMipMap = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static RenderTexture CreateDepthTexture(string name, int res) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static RenderTexture CreateRenderTexture(
    string name,
    RenderTexture referenceTex,
    int downscale,
    bool useMipMap = true)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RenderTextureHelper() => throw null;
}
