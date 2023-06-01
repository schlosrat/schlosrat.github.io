// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.AxleSuspensionChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class AxleSuspensionChart : PerformanceChart
  {
    private DataLogger.Channel m_steerAngle;
    private DataLogger.Channel m_yawRate;
    private DataLogger.Channel m_roll;
    private DataLogger.Channel m_yawRateVsSteer;
    private DataLogger.Channel m_leftCompression;
    private DataLogger.Channel m_rightCompression;
    private DataLogger.Channel m_compressionDiff;
    private DataLogger.Channel m_leftSpring;
    private DataLogger.Channel m_rightSpring;
    private int m_monitoredAxle;

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
    public AxleSuspensionChart() => throw null;
  }
}
