// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedSituation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
