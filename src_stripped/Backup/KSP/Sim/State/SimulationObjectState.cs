// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.SimulationObjectState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct SimulationObjectState
  {
    public FramePositionState position;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SimulationObjectState FromSimulationObject(SimulationObjectModel simObject) => throw null;
  }
}
