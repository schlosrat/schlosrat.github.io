// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedTravelObjectEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
