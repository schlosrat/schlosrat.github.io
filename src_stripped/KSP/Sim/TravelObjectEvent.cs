// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelObjectEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
