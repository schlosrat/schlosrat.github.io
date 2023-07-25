// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.ElectricMotor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class ElectricMotor : Block
  {
    public float motorInput;
    public int direction;
    public ElectricMotor.Settings settings;
    private Block.Connection m_output;
    private float m_sensorLoad;

    public float angularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float torque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorLoad
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CheckConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ElectricMotor() => throw null;

    [Serializable]
    public class Settings
    {
      public float maxDriveTorque;
      public float maxBrakeTorque;
      public Vector2 d0;
      public Vector2 d1;
      public Vector2 d2;
      public Vector2 d3;
      [Range(0.0f, 1f)]
      public float a;
      [Range(0.0f, 1f)]
      public float b;
      [Range(0.0f, 1f)]
      public float c;
      [Range(0.0f, 1f)]
      public float d;
      [Range(0.0f, 1f)]
      public float e;
      [Range(0.0f, 1f)]
      public float f;
      public Vector2 b0;
      public Vector2 b1;
      [Range(0.0f, 1f)]
      public float g;
      [Range(0.0f, 1f)]
      public float h;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float EvaluateDriveCurve(float rpm) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float EvaluateBrakeCurve(float rpm) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
