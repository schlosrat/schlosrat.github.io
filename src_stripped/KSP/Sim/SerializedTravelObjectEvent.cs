// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedTravelObjectEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedTravelObjectEvent
  {
    public List<Guid> TravelObjectIds;
    public string EventKey;
    public double UT;
    public string[] FlightReportArgs;

    [JsonConstructor]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedTravelObjectEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedTravelObjectEvent(TravelObjectEvent tEvent) => throw null;
  }
}
