// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPDiagnosticsCharts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Telemetry/Diagnostics Chart Set", 21)]
  [RequireComponent(typeof (VPPerformanceDisplay))]
  public class VPDiagnosticsCharts : MonoBehaviour
  {
    public VPDiagnosticsCharts.Charts chart;
    public int monitoredWheel;
    public float maxBrakeTorque;
    private PerformanceChart[] m_charts;
    private VPPerformanceDisplay m_perfComponent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPDiagnosticsCharts() => throw null;

    public enum Charts
    {
      AbsDiagnostics,
      AxleSuspension,
      SuspensionAnalysis,
      KineticEnergy,
    }
  }
}
