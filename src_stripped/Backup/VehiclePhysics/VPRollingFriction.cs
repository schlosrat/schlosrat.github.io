// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPRollingFriction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Vehicle Dynamics/Rolling Friction", 41)]
  public class VPRollingFriction : VehicleBehaviour, ISerializationCallbackReceiver
  {
    [FormerlySerializedAs("model")]
    public VPRollingFriction.Model dynamicModel;
    [Tooltip("Coefficient applied above Static Speed Threshold. Friction calculated with the selected friction model.")]
    public float dynamicCoefficient;
    [Space(5f)]
    [Tooltip("Coefficient applied with the vehicle stopped. Friction calculated using Constant model.")]
    public float staticCoefficient;
    [Tooltip("The coefficent applied shifts progressively from static at 0 speed to dynamic at this speed and above (m/s)")]
    public float staticSpeedThreshold;
    [FormerlySerializedAs("frictionFactors")]
    [Space(5f)]
    public float[] axleFrictionFactors;
    [Space(5f)]
    [Tooltip("Shows a GUI label with the accumulated rolling friction force (RFF) applied in N")]
    public bool showDebugLabel;
    [HideInInspector]
    [Obsolete("Coefficient is deprecated. Use dynamicCoefficient instead.")]
    public float coefficient;
    [HideInInspector]
    public int version;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAfterDeserialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBeforeSerialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyRollingFriction(int wheelIndex, float factor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPRollingFriction() => throw null;

    public enum Model
    {
      Constant,
      Linear,
      Quadratic,
    }
  }
}
