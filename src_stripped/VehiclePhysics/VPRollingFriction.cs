// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPRollingFriction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [Tooltip("Coefficient applied with the vehicle stopped. Friction calculated using Constant model.")]
    [Space(5f)]
    public float staticCoefficient;
    [Tooltip("The coefficent applied shifts progressively from static at 0 speed to dynamic at this speed and above (m/s)")]
    public float staticSpeedThreshold;
    [Space(5f)]
    [FormerlySerializedAs("frictionFactors")]
    public float[] axleFrictionFactors;
    [Space(5f)]
    [Tooltip("Shows a GUI label with the accumulated rolling friction force (RFF) applied in N")]
    public bool showDebugLabel;
    [Obsolete("Coefficient is deprecated. Use dynamicCoefficient instead.")]
    [HideInInspector]
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
