// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Wheel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class Wheel : Block
  {
    public TireFriction tireFriction;
    public float radius;
    public float mass;
    private float I;
    private float invI;
    public float load;
    public float grip;
    public Vector2 V;
    public Vector2 Fext;
    private float m_brakeTorque;
    public float L;
    public Vector2 P;
    private float w;
    public float T;
    public Vector2 F;
    public float Tr;
    public bool isResting;
    public float m_forwardSlip;
    public Vector2 m_tireForce;
    public bool m_isAdherent;
    public Vector2 m_adherentSlip;
    private float m_inTd;
    private float m_inTb;
    private TireFriction.ContactPatch m_contact;
    public float debug1;
    public float debug2;
    public float debug3;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecalculateConstants() => throw null;

    public float inertia
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float AddBrakeTorque(float brakeTorque) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetBrakeTorque() => throw null;

    public float angularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecalculateVars() => throw null;

    public float driveTorque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float brakeTorque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public TireFriction.ContactPatch contactPatch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetState(ref Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetSubstepState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ComputeStateUpstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetSubstepDerivative(ref Block.Derivative D) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float SolveSymmetricConstraint(float Tsum, float T, float Tmax) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Wheel() => throw null;
  }
}
