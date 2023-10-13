// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPForceCones
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Telemetry/Force Cones", 2)]
  public class VPForceCones : VehicleBehaviour
  {
    public float baseLength;
    [FormerlySerializedAs("showDownforce")]
    public bool showVerticalForce;
    public bool showTireForce;
    public bool combinedTireForce;
    public bool useLogScale;
    private VPForceCones.Cones[] m_wheelCones;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Transform CreateConeObject(string name, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 ScaledForce(float force) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPForceCones() => throw null;

    private struct Cones
    {
      public Transform red;
      public Transform green;
      public Transform blue;
      public Transform gray;
    }
  }
}
