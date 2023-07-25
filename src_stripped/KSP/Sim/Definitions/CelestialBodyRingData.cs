// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.CelestialBodyRingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
