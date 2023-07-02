// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPBlockDebugger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class VPBlockDebugger : VehicleBehaviour
  {
    public VPBlockDebugger.AngularVelocityUnits angularVelocityUnits;
    public VPBlockDebugger.ChangeDetection changeDetection;
    public float changeTolerance;
    [Space(5f)]
    public Font font;
    public Texture2D boxTexture;
    public Vector2 screenPosition;
    private List<VehicleBase.SolverState> m_states;
    private GUIStyle m_style;
    private GUIStyle m_boxStyle;
    private string m_text;
    private int m_charWidth;
    private int m_lineLength;
    private int m_lines;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecordSolverState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTextProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTelemetryData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetAngularVelocity(VehicleBase.BlockState blockState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetIntString(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetFloatString(float value, float prevValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetFloatString(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetTypeString(System.Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPBlockDebugger() => throw null;

    public enum AngularVelocityUnits
    {
      RadsPerSec,
      RevsPerMin,
    }

    public enum ChangeDetection
    {
      Exact,
      Tolerance,
    }
  }
}
