// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.RenderTextureFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class RenderTextureFactory : IDisposable
  {
    private HashSet<RenderTexture> m_TemporaryRTs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RenderTextureFactory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RenderTexture Get(RenderTexture baseRenderTexture) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RenderTexture Get(
      int width,
      int height,
      int depthBuffer = 0,
      RenderTextureFormat format = RenderTextureFormat.ARGBHalf,
      RenderTextureReadWrite rw = RenderTextureReadWrite.Default,
      FilterMode filterMode = FilterMode.Bilinear,
      TextureWrapMode wrapMode = TextureWrapMode.Clamp,
      string name = "FactoryTempTexture")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Release(RenderTexture rt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
