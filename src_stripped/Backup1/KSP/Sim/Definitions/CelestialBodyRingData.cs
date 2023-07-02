// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.CelestialBodyRingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public class CelestialBodyRingData
  {
    public double innerRadius;
    public double outerRadius;
    public FloatCurve density;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyRingData() => throw null;
  }
}
