// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelObjectEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class TravelObjectEvent
  {
    public List<IGGuid> TravelObjectIds;
    public string EventKey;
    public double UT;
    public string[] FlightReportArgs;
    public string FlightReportMessage;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TravelObjectEvent() => throw null;
  }
}
