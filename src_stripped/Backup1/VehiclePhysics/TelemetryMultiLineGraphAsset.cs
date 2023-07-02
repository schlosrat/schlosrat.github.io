// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.TelemetryMultiLineGraphAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [CreateAssetMenu(fileName = "VPP Multi-Line Graph Telemetry Template", menuName = "Vehicle Physics/Telemetry Templates/Multi-Line Graph", order = 508)]
  public class TelemetryMultiLineGraphAsset : TelemetryTemplateAssetBase
  {
    public TelemetryMultiLineGraph.Settings settings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override TelemetryTemplateBase GetTelemetryTemplate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TelemetryMultiLineGraphAsset() => throw null;
  }
}
