// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelEventFlightReportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
