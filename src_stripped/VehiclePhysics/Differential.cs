// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Differential
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class Differential : Block
  {
    public Differential.Settings settings;
    public float damping;
    private Block.Connection m_input;
    private Block.Connection m_output1;
    private Block.Connection m_output2;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CheckConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ComputeStateUpstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ComputeLockingTorque(float dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Differential() => throw null;

    public enum Type
    {
      Open,
      Locked,
      Viscous,
      ClutchPack,
      TorqueBias,
    }

    [Serializable]
    public class Settings
    {
      public Differential.Type type;
      [Range(1f, 12f)]
      public float gearRatio;
      public float preload;
      [Range(0.0f, 1f)]
      public float powerStiffness;
      [Range(0.0f, 1f)]
      public float coastStiffness;
      public float clutchPreload;
      [Range(0.0f, 1f)]
      public float clutchPackFriction;
      [Range(10f, 90f)]
      public float powerAngle;
      [Range(10f, 90f)]
      public float coastAngle;
      public float torquePreload;
      [Range(1f, 10f)]
      public float powerRatio;
      [Range(1f, 10f)]
      public float coastRatio;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
