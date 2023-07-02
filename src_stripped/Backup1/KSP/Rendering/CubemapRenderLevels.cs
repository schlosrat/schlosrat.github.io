// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CubemapRenderLevels
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
