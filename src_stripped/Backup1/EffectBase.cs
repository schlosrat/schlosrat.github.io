// Decompiled with JetBrains decompiler
// Type: EffectBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class EffectBase : MonoBehaviour
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void EnsureArray<T>(ref T[] array, int size, T initialValue = null) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void EnsureArray<T>(ref T[,] array, int size0, int size1, T defaultValue = null) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void EnsureMaterial(ref Material material, Shader shader) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void EnsureDepthTexture(Camera camera) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void EnsureKeyword(Material material, string name, bool enabled) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void EnsureRenderTarget(
    ref RenderTexture rt,
    int width,
    int height,
    RenderTextureFormat format,
    FilterMode filterMode,
    bool useMipmap,
    string name)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void EnsureRenderTarget(
    ref RenderTexture rt,
    int width,
    int height,
    RenderTextureFormat format,
    FilterMode filterMode,
    string name)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void EnsureRenderTarget(
    ref RenderTexture rt,
    int width,
    int height,
    RenderTextureFormat format,
    FilterMode filterMode,
    TextureWrapMode wrapMode = TextureWrapMode.Clamp,
    bool randomWrite = false,
    bool useMipmap = false,
    int depthBits = 0,
    int antiAliasing = 1,
    string name = "EffectBase_Unnamed")
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ReleaseRenderTarget(ref RenderTexture rt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DrawFullscreenQuad() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected EffectBase() => throw null;
}
