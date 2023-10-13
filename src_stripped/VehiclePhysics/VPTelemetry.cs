// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTelemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Telemetry/Telemetry Window", 0)]
  public class VPTelemetry : VehicleBehaviour
  {
    [FormerlySerializedAs("showData")]
    public bool showTelemetry;
    [Space(5f)]
    public VPTelemetry.Suspension showSuspensionAs;
    public VPTelemetry.LoadUnits loadUnits;
    public VPTelemetry.TireData tireData;
    [Space(5f)]
    public bool enableHotKey;
    public KeyCode hotKey;
    [Space(5f)]
    public Vector2 screenPosition;
    public Font font;
    [Header("Debug Gizmos")]
    public bool showCenterOfMass;
    public bool gizmosAtPhysicPositions;
    [FormerlySerializedAs("showGizmos")]
    public bool showWheelGizmos;
    [Header("Wheel Gizmos")]
    public bool showLocalFrame;
    public bool showContactPoints;
    public bool showTireSlip;
    public bool showTireForces;
    public bool showSurfaceForces;
    public bool useLogScale;
    public static string customData;
    private GUIStyle m_smallStyle;
    private GUIStyle m_bigStyle;
    private StringBuilder m_text;
    private StringBuilder m_bigText;
    private string m_composedText;
    private string m_composedBigText;
    private int m_lines;
    private int m_frameNum;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateAfterFixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTextProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawWheelGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawSingleWheelGizmos(VehicleBase.WheelState wheel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetGearStr(int gear) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetGearModeStr(Gearbox.AutomaticGear gearMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetWheelTelemetryHeader(StringBuilder text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AppendTelemetryData(StringBuilder text, VehicleBase.WheelState wheel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComposeTelemetryText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ComputeSlope() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetGroundedWheelIndex(int axle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VPTelemetry() => throw null;

    public enum Suspension
    {
      Ratio,
      Depth,
    }

    public enum LoadUnits
    {
      Newtons,
      Kilograms,
    }

    public enum TireData
    {
      ForceAndSlip,
      FrictionAndGroundMaterial,
    }
  }
}
