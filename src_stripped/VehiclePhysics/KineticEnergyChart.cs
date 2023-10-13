// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.KineticEnergyChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class KineticEnergyChart : PerformanceChart
  {
    private DataLogger.Channel m_totalEnergy;
    private DataLogger.Channel m_linearEnergy;
    private DataLogger.Channel m_angularEnergy;
    private DataLogger.Channel m_totalEnergyDelta;
    private DataLogger.Channel m_linearEnergyDelta;
    private DataLogger.Channel m_angularEnergyDelta;
    private float m_lastTotalEnergy;
    private float m_lastLinearEnergy;
    private float m_lastAngularEnergy;

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
    public KineticEnergyChart() => throw null;
  }
}
