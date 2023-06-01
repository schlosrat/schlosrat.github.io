// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPWeightMonitor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class VPWeightMonitor : VehicleBehaviour
  {
    public bool showAxleGroups;
    public VPWeightMonitor.AxleGroup[] axleGroups;
    public Vector2 screenPosition;
    public Font font;
    private GUIStyle m_textStyle;
    private string m_text;
    private string m_groups;
    private float[] m_axleWeights;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTextStyle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetWeightInAxle(int axle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPWeightMonitor() => throw null;

    [Serializable]
    public class AxleGroup
    {
      public int[] axles;
      public float specification;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AxleGroup() => throw null;
    }
  }
}
