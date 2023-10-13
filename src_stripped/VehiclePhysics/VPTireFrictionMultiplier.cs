// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTireFrictionMultiplier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
