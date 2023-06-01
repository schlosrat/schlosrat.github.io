// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Inertia
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class Inertia
  {
    public Inertia.Settings settings;
    public static float lowerLimitRatio;
    public static Color inertiaGizmosColor;
    private Inertia.Mode m_lastMode;
    private Vector3 m_lastDimensions;
    private float m_lastBias;
    private Vector3 m_lastInertiaTensor;
    private Vector3 m_lastInertiaRotation;
    private float m_lastMass;
    private Vector3 m_lastInertiaRow0;
    private Vector3 m_lastInertiaRow1;
    private Vector3 m_lastInertiaRow2;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(Rigidbody rigidbody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoUpdate(Rigidbody rigidbody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Apply(Rigidbody rigidbody, bool firstRun = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyInertiaFromColliders(Rigidbody rigidbody, Collider[] inertiaColliders) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyParametricInertia(
      Rigidbody rigidbody,
      Vector3 dimensions,
      float inertiaBias)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyExplicitInertia(
      Rigidbody rigidbody,
      Vector3 inertiaTensor,
      Vector3 inertiaTensorRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyInertiaTensorMatrix(
      Rigidbody rigidbody,
      Vector3 inertiaRow0,
      Vector3 inertiaRow1,
      Vector3 inertiaRow2)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void VerifyInertiaAndShowWarning(Rigidbody rigidbody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3 ComputeBoxInertia(Vector3 dimensions, float mass) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawGizmo(Inertia.Settings settings, Rigidbody rigidbody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Inertia() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Inertia() => throw null;

    public enum Mode
    {
      Default,
      Parametric,
      InertiaColliders,
      Explicit,
      InertiaTensorMatrix,
    }

    [Serializable]
    public class Settings
    {
      public Inertia.Mode mode;
      public Collider[] inertiaColliders;
      public Vector3 chassisDimensions;
      [Range(-5f, 5f)]
      public float inertiaBias;
      public Vector3 inertiaTensor;
      public Vector3 inertiaTensorRotation;
      public Vector3 inertiaRow0;
      public Vector3 inertiaRow1;
      public Vector3 inertiaRow2;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
