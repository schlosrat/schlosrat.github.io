// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PIDclamp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class PIDclamp : IPid
  {
    public const float KP_SCALAR = 1f;
    public const float KI_SCALAR = 1f;
    public const float KD_SCALAR = 1f;
    public string Name;
    public double Kp;
    public double Ki;
    public double Kd;
    public double Clamp;
    public double TuningScalar;
    public double ClampScalar;
    private double integral;
    private double integralLast;
    private double derivative;
    private double errorLast;
    private double output;
    public bool IgnoreIntegral;
    private bool clampIntegral;
    private const double INTEGRAL_MAX = 1.0;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PIDclamp(string name, float kp, float ki, float kd, float clamp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reinitialize(string name, float kp, float ki, float kd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reinitialize(float kp, float ki, float kd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetIntegral() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetIntegralAndNegateError() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double Update(double error, double dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Update(float error, float dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator double(PIDclamp v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PIDclamp Parse(string s) => throw null;
  }
}
