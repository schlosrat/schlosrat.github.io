// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPDiagnosticsCharts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [RequireComponent(typeof (VPPerformanceDisplay))]
  [AddComponentMenu("Vehicle Physics/Telemetry/Diagnostics Chart Set", 21)]
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
