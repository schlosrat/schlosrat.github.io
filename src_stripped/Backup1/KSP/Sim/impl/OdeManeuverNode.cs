// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.OdeManeuverNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
