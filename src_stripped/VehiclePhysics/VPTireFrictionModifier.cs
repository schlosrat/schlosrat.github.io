// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTireFrictionModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Vehicle Dynamics/Tire Friction Modifier", 42)]
  public class VPTireFrictionModifier : VehicleBehaviour
  {
    public int axle;
    public VPTireFrictionModifier.Wheel wheel;
    public TireFriction tireFriction;
    private TireFriction m_originalLeftFriction;
    private TireFriction m_originalRightFriction;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPTireFrictionModifier() => throw null;

    public enum Wheel
    {
      Left,
      Right,
      Both,
    }
  }
}
