// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.SimulationObjectStateContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;

namespace KSP.Sim.State
{
  public struct SimulationObjectStateContainer
  {
    public SimulationObjectState? state;
    public Dictionary<Type, object> componentStates;
  }
}
