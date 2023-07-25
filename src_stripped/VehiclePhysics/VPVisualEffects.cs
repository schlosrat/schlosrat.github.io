// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPVisualEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using EdyCommonTools;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Effects/Visual Effects", 4)]
  public class VPVisualEffects : VehicleBehaviour
  {
    [Header("Steering wheel")]
    public Transform steeringWheel;
    public float degreesOfRotation;
    public MathUtility.Axis localRotationAxis;
    [Header("Lights")]
    [FormerlySerializedAs("brakeLightsGlow")]
    public GameObject[] brakeLightsOn;
    public GameObject[] brakeLightsOff;
    [FormerlySerializedAs("reverseLightsGlow")]
    public GameObject[] reverseLightsOn;
    public GameObject[] reverseLightsOff;
    [FormerlySerializedAs("headLights")]
    [FormerlySerializedAs("headLightsGlow")]
    public GameObject[] headLightsOn;
    public GameObject[] headLightsOff;
    public bool headLightsEnabled;
    public KeyCode headLightsToggleKey;
    [Header("Dashboard")]
    public Transform rpmGauge;
    public float rpmMax;
    public float rpmMinAngle;
    public float rpmMaxAngle;
    [Space(5f)]
    public Transform speedGauge;
    public float speedMaxKph;
    public float speedMinAngle;
    public float speedMaxAngle;
    [Space(5f)]
    public GameObject[] dashboardOn;
    public GameObject[] dashboardOff;
    [Space(5f)]
    public GameObject stalledLightsOn;
    public GameObject stalledLightsOff;
    public GameObject handbrakeLightsOn;
    public GameObject handbrakeLightsOff;
    private InterpolatedFloat m_steerInput;
    private InterpolatedFloat m_speedMs;
    private InterpolatedFloat m_engineRpm;
    private Transform m_originalSteeringWheel;
    private Quaternion m_originalSteeringWheelRotation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGameObjectsActive(GameObject[] gameObjects, bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPVisualEffects() => throw null;
  }
}
