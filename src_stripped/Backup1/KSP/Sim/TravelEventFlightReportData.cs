// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelEventFlightReportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
