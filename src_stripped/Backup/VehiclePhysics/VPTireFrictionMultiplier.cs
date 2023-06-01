// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTireFrictionMultiplier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class VPTireFrictionMultiplier : VehicleBehaviour
  {
    [Range(0.0f, 2f)]
    public float frictionMultiplier;
    private float m_lastValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetFrictionMultiplierInAllWheels(VehicleBase vehicle, float multiplier) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPTireFrictionMultiplier() => throw null;
  }
}
