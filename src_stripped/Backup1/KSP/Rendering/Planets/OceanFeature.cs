// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.OceanFeature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Rendering.Planets
{
  [Serializable]
  public struct OceanFeature
  {
    public OceanSpectrumPrecision SpectrumPrecision;
    public bool Foam;
    public UnderWaterGodRayQuality GodRayQuality;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OceanFeature(
      OceanSpectrumPrecision precision,
      bool foam,
      UnderWaterGodRayQuality godrayQuality)
    {
      throw null;
    }
  }
}
