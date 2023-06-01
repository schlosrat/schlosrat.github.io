// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CubemapRenderLevels
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Rendering
{
  [Serializable]
  public struct CubemapRenderLevels
  {
    public float RenderRate;
    public float BlendRate;
    public float DownscaleFactor;
    public float TimeWarpFallbackBlend;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CubemapRenderLevels(
      float renderRate,
      float blendRate,
      float downscaleFactor,
      float timeWarpFallbackBlend)
    {
      throw null;
    }
  }
}
