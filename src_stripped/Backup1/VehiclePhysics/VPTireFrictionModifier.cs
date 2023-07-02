// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTireFrictionModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
