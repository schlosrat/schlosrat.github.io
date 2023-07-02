// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.TireFriction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [Serializable]
  public class TireFriction : ISerializationCallbackReceiver
  {
    public TireFriction.Model model;
    public TireFriction.Settings settings;
    public float frictionMultiplier;
    public float maxAdherentSpeed;
    private TireFriction.CurveBase m_curve;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBeforeSerialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAfterDeserialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupFrictionCurves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TireFriction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetForce(TireFriction.ContactPatch cp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetAdherentSlip(TireFriction.ContactPatch cp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAdherentSlip(TireFriction.ContactPatch cp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ComputeAdherentForceForward(TireFriction.ContactPatch cp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ComputeAdherentForceSideways(TireFriction.ContactPatch cp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetAdherentSlipBounds(TireFriction.ContactPatch cp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetPeakSlipBounds(TireFriction.ContactPatch cp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetLimitSlipBounds(TireFriction.ContactPatch cp) => throw null;

    public enum Model
    {
      Flat,
      Linear,
      Smooth,
      Parametric,
      Pacejka,
    }

    [Serializable]
    public class Settings
    {
      public float adherentFriction;
      public Vector2 peak;
      public Vector2 limit;
      [Range(0.0f, 1f)]
      public float a;
      [Range(0.0f, 1f)]
      public float b;
      [Range(0.0f, 1f)]
      public float c;
      [Range(0.0f, 1f)]
      public float d;
      [Range(0.01f, 2f)]
      public float A;
      [Range(0.2f, 4f)]
      public float B;
      [Range(1f, 2f)]
      public float C;
      [Range(0.0f, 2f)]
      public float D;
      [Range(-20f, 1f)]
      public float E;
      [Obsolete("Use new adherentFriction setting for configuring the adherent coefficient of friction (Formerly adherent.y). adherent.x is now calculated automatically. Flat friction model now uses peak.x, peak.y.")]
      public Vector2 adherent;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ApplyAPLConstraints() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }

    public class ContactPatch
    {
      public float load;
      public Vector2 slip;
      public Vector2 localVelocity;
      public float groundGrip;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ContactPatch() => throw null;
    }

    public class CurveBase
    {
      protected TireFriction.Settings m_settings;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CurveBase(TireFriction.Settings settings) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual float EvaluateForce(float slip, TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual float GetAdherentSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual float GetPeakSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual float GetLimitSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static float FindValue(Func<float, float> function, float y, float x0, float x1) => throw null;
    }

    public class FlatFriction : TireFriction.CurveBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public FlatFriction(TireFriction.Settings settings) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float EvaluateForce(float s, TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetAdherentSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetPeakSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetLimitSlip(TireFriction.ContactPatch cp) => throw null;
    }

    public class LinealFriction : TireFriction.CurveBase
    {
      private float m_adherentSlip;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LinealFriction(TireFriction.Settings settings) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float EvaluateForce(float s, TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetAdherentSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetPeakSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetLimitSlip(TireFriction.ContactPatch cp) => throw null;
    }

    public class SmoothFriction : TireFriction.CurveBase
    {
      private float m_adherentSlip;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SmoothFriction(TireFriction.Settings settings) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float EvaluateForce(float s, TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetAdherentSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetPeakSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetLimitSlip(TireFriction.ContactPatch cp) => throw null;
    }

    public class ParametricFriction : TireFriction.CurveBase
    {
      private float m_adherentSlip;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ParametricFriction(TireFriction.Settings settings) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float EvaluateForce(float s, TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetAdherentSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetPeakSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetLimitSlip(TireFriction.ContactPatch cp) => throw null;
    }

    public class PacejkaFriction : TireFriction.CurveBase
    {
      private Vector2 m_adherent;
      private Vector2 m_peak;
      private Vector2 m_limit;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PacejkaFriction(TireFriction.Settings settings) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void GetPacejkaPoints(
        float A,
        float B,
        float C,
        float D,
        float E,
        ref Vector2 adherent,
        ref Vector2 peak,
        ref Vector2 limit)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static float Pacejka(float slip, float B, float C, float D, float E) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float EvaluateForce(float s, TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetAdherentSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetPeakSlip(TireFriction.ContactPatch cp) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override float GetLimitSlip(TireFriction.ContactPatch cp) => throw null;
    }
  }
}
