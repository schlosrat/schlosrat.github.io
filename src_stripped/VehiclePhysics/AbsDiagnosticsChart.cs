// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.AbsDiagnosticsChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class AbsDiagnosticsChart : PerformanceChart
  {
    private DataLogger.Channel m_speed;
    private DataLogger.Channel m_brakePedal;
    private DataLogger.Channel m_brakeTorque;
    private DataLogger.Channel m_wheelSpin;
    private DataLogger.Channel m_longitudinalG;
    private DataLogger.Channel m_slip;
    public int monitoredWheel;
    public float maxBrakeTorque;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string Title() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ResetView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupChannels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RecordData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbsDiagnosticsChart() => throw null;
  }
}
