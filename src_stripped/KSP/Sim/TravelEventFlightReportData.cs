// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelEventFlightReportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public struct TravelEventFlightReportData
  {
    public FlightReportStyle Style;
    [JsonIgnore]
    public string MessageTemplate;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TravelEventFlightReportData(FlightReportStyle style, string messageTemplate) => throw null;
  }
}
