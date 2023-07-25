// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelObjectEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
