// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPVehicleInertia
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  public class VPVehicleInertia : VehicleBehaviour
  {
    public bool visualize;
    public bool showLabel;
    [FormerlySerializedAs("chassisColliders")]
    public Collider[] inertiaColliders;
    private Vector3 m_labelPosition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPVehicleInertia() => throw null;
  }
}
