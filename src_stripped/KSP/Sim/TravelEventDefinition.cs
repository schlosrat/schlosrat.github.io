// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelEventDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public struct TravelEventDefinition
  {
    public readonly string EventKey;
    public TravelEventFlightReportData ReportData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TravelEventDefinition(string newEventKey, TravelEventFlightReportData reportData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetFlightReportMessage(params string[] args) => throw null;
  }
}
