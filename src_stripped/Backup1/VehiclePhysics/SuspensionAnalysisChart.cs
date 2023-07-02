// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.SuspensionAnalysisChart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class SuspensionAnalysisChart : PerformanceChart
  {
    private DataLogger.Channel m_contactDepth;
    private DataLogger.Channel m_contactSpeed;
    private DataLogger.Channel m_suspensionForce;
    private DataLogger.Channel m_damperForce;
    private DataLogger.Channel m_suspensionTravel;
    private int monitoredWheel;

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
    public SuspensionAnalysisChart() => throw null;
  }
}
