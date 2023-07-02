// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Retarder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using EdyCommonTools;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class Retarder : Block
  {
    public int retarderInput;
    public float onDemandTorque;
    public Retarder.Settings settings;
    private Block.Connection m_input;
    private Block.Connection m_output;
    private float m_rpm;
    private float m_retarderTorque;
    private float m_availableOnDemandTorque;
    private BiasedRatio m_torqueRatioBias;

    public float sensorRetarderTorque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorAvailableOnDemandTorque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CheckConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PreStep() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ComputeStateUpstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float EvaluateRetarderTorque(float rpm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMaxOperationalRpms() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetPeakRpms() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Retarder() => throw null;

    public enum Curve
    {
      Simple,
      Parametric,
    }

    [Serializable]
    public class Settings
    {
      [Range(0.0f, 10f)]
      public int levels;
      public Retarder.Curve curve;
      public float maxTorque;
      public float minRpm;
      public float maxRpm;
      [Range(0.001f, 0.999f)]
      public float curveBias;
      public float baseRpm;
      public float peakRpm;
      public float peakTorque;
      public float limitRpm;
      public float limitTorque;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
