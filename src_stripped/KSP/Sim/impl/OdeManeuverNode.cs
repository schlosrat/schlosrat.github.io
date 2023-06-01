// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.OdeManeuverNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public readonly struct OdeManeuverNode
  {
    public readonly double UniversalTime;
    public readonly double DeltaVMagnitude;
    public readonly Vector DeltaV;
    public readonly List<OdeStage> OdeStages;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OdeManeuverNode(
      Vector deltaV,
      double deltaVMagnitude,
      List<OdeStage> odeStages,
      double universalTime)
    {
      throw null;
    }
  }
}
