// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPXboxInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Input/XBox Input", 2)]
  public class VPXboxInput : VehicleBehaviour
  {
    public XboxDevice device;
    [Space(5f)]
    [Range(0.0f, 1f)]
    public float steeringNonlinearity;
    [Range(0.0f, 0.9f)]
    public float steeringDeadZone;
    public float steeringMoveRate;
    public float steeringCenterRate;
    public float digitalHandbrakeRate;
    public float digitalClutchRate;
    public bool pressClutchWithHandbrake;
    public bool unlockDrivelineOnHandbrake;
    [Space(5f)]
    public XboxButtons gearShiftUp;
    public XboxButtons gearShiftDown;
    public XboxButtons automaticGearNext;
    public XboxButtons automaticGearPrev;
    public XboxButtons ignitionKeyOn;
    public XboxButtons ignitionKeyOff;
    public XboxButtons handbrake;
    public XboxButtons clutch;
    [Space(5f)]
    public bool debugInfo;
    [NonSerialized]
    public bool attached;
    [NonSerialized]
    public int leftTrigger;
    [NonSerialized]
    public int rightTrigger;
    [NonSerialized]
    public int leftThumbX;
    [NonSerialized]
    public int leftThumbY;
    [NonSerialized]
    public int rightThumbX;
    [NonSerialized]
    public int rightThumbY;
    [NonSerialized]
    public string buttons;
    private XINPUT_STATE m_state;
    private XINPUT_STATE m_prevState;
    private XboxDevice m_currentDevice;
    private bool m_drivelineLocked;
    private float m_handbrakeInput;
    private float m_clutchInput;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetButton(XboxButtons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetButtonDown(XboxButtons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetButtonUp(XboxButtons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float ProcessSymmetricValue(
      float currentValue,
      float newValue,
      float moveRate,
      float centerRate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPXboxInput() => throw null;
  }
}
