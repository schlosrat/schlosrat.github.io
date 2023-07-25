// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.SolarPanelStarExposureData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  [Serializable]
  public class SolarPanelStarExposureData
  {
    public CelestialBodyComponent StarBody;
    public double StarFlux;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SolarPanelStarExposureData() => throw null;
  }
}
