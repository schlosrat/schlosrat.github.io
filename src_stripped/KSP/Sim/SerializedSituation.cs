// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedSituation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
