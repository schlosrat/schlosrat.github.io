// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.KineticEnergyChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
