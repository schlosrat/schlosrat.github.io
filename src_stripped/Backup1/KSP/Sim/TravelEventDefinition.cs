// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelEventDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
