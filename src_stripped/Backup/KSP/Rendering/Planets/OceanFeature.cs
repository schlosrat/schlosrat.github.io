// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.OceanFeature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
