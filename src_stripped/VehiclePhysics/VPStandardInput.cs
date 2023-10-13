// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPStandardInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Input/Standard Input", 0)]
  public class VPStandardInput : VehicleBehaviour
  {
    public VPStandardInput.ThrottleAndBrakeMode throttleAndBrakeMode;
    [FormerlySerializedAs("autoApplyBrakeOnBackwards")]
    public bool brakeOnThrottleBackwards;
    public bool applyClutchOnHandbrake;
    [FormerlySerializedAs("unlockTranmissionOnHandbrake")]
    public bool unlockDrivelineOnHandbrake;
    [Space(10f)]
    public bool progressiveSteerMode;
    [Range(0.01f, 1f)]
    public float movementRate;
    [Range(0.0f, 1f)]
    public float autoCenterRate;
    [Space(10f)]
    public KeyCode ignitionKey;
    public string steerAxis;
    public string throttleAndBrakeAxis;
    public string handbrakeAxis;
    public string clutchAxis;
    public string gearShiftButton;
    public string gearModeSelectButton;
    public bool keyboardNumbersSelectGears;
    public KeyCode neutralGear;
    public KeyCode reverseGear;
    [Space(10f)]
    [Range(0.0f, 1f)]
    public float externalThrottle;
    public bool reverse;
    [Range(0.0f, 1f)]
    public float externalBrake;
    [Range(0.0f, 1f)]
    public float externalHandbrake;
    [Range(-1f, 1f)]
    public float externalSteer;
    [Range(0.0f, 1f)]
    public float externalClutch;
    public VPStandardInput.IgnitionKey externalIgnition;
    public bool lockBrakesOnEnable;
    private bool m_handbrakeLock;
    private bool m_handbrakeButtonDown;
    private bool m_drivelineLocked;
    private VPStandardInput.IgnitionKey m_prevExternalIgnition;
    private float m_steerValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetAxis(string axisName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetAxisRaw(string axisName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetButtonDown(string buttonName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPStandardInput() => throw null;

    public enum ThrottleAndBrakeMode
    {
      ThrottleAndBrake,
      AutoForwardAndReverse,
    }

    public enum IgnitionKey
    {
      Off,
      AccOn,
      Start,
    }
  }
}
