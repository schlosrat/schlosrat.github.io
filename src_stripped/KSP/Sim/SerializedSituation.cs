// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedSituation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using System;
using System.Collections.Generic;

namespace KSP.Sim
{
  [Obsolete("SerializedVessel should be refactored to separate out part states, etc and replace this")]
  public struct SerializedSituation
  {
    public SimulationObjectState? simObjectState;
    public Dictionary<string, object> componentDefinitions;
    public Dictionary<string, object> componentStates;
  }
}
