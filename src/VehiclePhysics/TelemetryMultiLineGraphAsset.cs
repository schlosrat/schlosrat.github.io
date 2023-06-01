// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.TelemetryMultiLineGraphAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
