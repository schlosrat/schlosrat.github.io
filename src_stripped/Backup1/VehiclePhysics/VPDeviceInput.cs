// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPDeviceInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Input/Device Input", 1)]
  public class VPDeviceInput : VehicleBehaviour
  {
    public int selectedDevice;
    public VPDeviceInput.DeviceModel deviceModel;
    [Range(0.0f, 1f)]
    public float steeringNonLinearBias;
    public float digitalHandbrakeRate;
    public bool unlockDrivelineOnHandbrake;
    public bool disableClutchInput;
    public bool fallbackToStandardInput;
    public bool disableVehicleSteeringAids;
    [Header("Pedal ranges")]
    public float throttleRangeMin;
    public float throttleRangeMax;
    public float brakeRangeMin;
    public float brakeRangeMax;
    public float clutchRangeMin;
    public float clutchRangeMax;
    [Header("Startup")]
    public VPDeviceInput.IgnitionKey ignitionKeyPosition;
    public VPDeviceInput.AutomaticGear automaticGearPosition;
    public int manualGearPosition;
    public bool handbrakeLocked;
    [Header("Force Feedback")]
    public float logicalTireWidth;
    [Range(0.0f, 2f)]
    public float forceIntensity;
    [Range(0.0f, 2f)]
    public float weightIntensity;
    [Range(0.0f, 1f)]
    public float nonLinearBias;
    [Range(0.0f, 1f)]
    public float damperCoefficient;
    [Space(5f)]
    public bool showForceFeedbackUI;
    public GameObject forceFeedbackUI;
    [Header("G27 Specific")]
    public VPDeviceInput.G27Buttons gearShiftUp;
    public VPDeviceInput.G27Buttons gearShiftDown;
    public VPDeviceInput.G27Buttons automaticGearNext;
    public VPDeviceInput.G27Buttons automaticGearPrev;
    public VPDeviceInput.G27Buttons ignitionKeyOn;
    public VPDeviceInput.G27Buttons ignitionKeyOff;
    public VPDeviceInput.G27Buttons handbrake;
    public VPDeviceInput.G27Buttons brakeLockToggle;
    public VPDeviceInput.G27Buttons retarderShiftUp;
    public VPDeviceInput.G27Buttons retarderShiftDown;
    [Header("G29 Specific")]
    public VPDeviceInput.G29Buttons g29GearShiftUp;
    public VPDeviceInput.G29Buttons g29GearShiftDown;
    public VPDeviceInput.G29Buttons g29AutomaticGearNext;
    public VPDeviceInput.G29Buttons g29AutomaticGearPrev;
    public VPDeviceInput.G29Buttons g29IgnitionKeyOn;
    public VPDeviceInput.G29Buttons g29IgnitionKeyOff;
    public VPDeviceInput.G29Buttons g29Handbrake;
    public VPDeviceInput.G29Buttons g29BrakeLockToggle;
    public VPDeviceInput.G29Buttons g29RetarderShiftUp;
    public VPDeviceInput.G29Buttons g29RetarderShiftDown;
    [Header("Tests & Debug")]
    public bool forceFeedbackGui;
    public float positionX;
    public float positionY;
    public Font font;
    [Space(5f)]
    public bool enableTestEffects;
    [Space(5f)]
    public bool enableForce;
    [Range(-100f, 100f)]
    public int force;
    [Space(5f)]
    public bool enableSpring;
    [Range(-100f, 100f)]
    public int springCenter;
    [Range(0.0f, 100f)]
    public int springSaturation;
    [Range(-100f, 100f)]
    public int springSlope;
    [Space(5f)]
    public bool enableDamper;
    [Range(-100f, 100f)]
    public int damperSlope;
    [Space(5f)]
    public bool enableFriction;
    [Range(0.0f, 100f)]
    public int frictionSaturation;
    [Range(0.0f, 100f)]
    public int frictionCoefficient;
    public bool debugGizmos;
    public bool debugInfo;
    private float m_forceFactor;
    private float m_damperFactor;
    [NonSerialized]
    public string deviceName;
    [NonSerialized]
    public string deviceCaps;
    [NonSerialized]
    public int lX;
    [NonSerialized]
    public int lY;
    [NonSerialized]
    public int lZ;
    [NonSerialized]
    public int lRx;
    [NonSerialized]
    public int lRy;
    [NonSerialized]
    public int lRz;
    [NonSerialized]
    public int rglSlider0;
    [NonSerialized]
    public int rglSlider1;
    [NonSerialized]
    public int rgdwPOV0;
    [NonSerialized]
    public int rgdwPOV1;
    [NonSerialized]
    public int rgdwPOV2;
    [NonSerialized]
    public int rgdwPOV3;
    [NonSerialized]
    public string rgbButtons;
    private DIJOYSTATE2 m_state;
    private DIJOYSTATE2 m_prevState;
    private int m_currentDevice;
    private bool m_testEffectsEnabled;
    private bool m_deviceReady;
    private float m_handbrakeInput;
    private bool m_handbrakeLock;
    private bool m_drivelineLocked;
    private bool m_clutchInputDisabled;
    private VPDeviceInput.WheelData[] m_wheelData;
    private GUIStyle m_style;
    private VPDeviceInput.ControllerInput m_controller;

    public float currentForceFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float currentDamperFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnApplicationPause(bool paused) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTextProperties() => throw null;

    [ContextMenu("Send DirectInput log to console")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LogToConsole() => throw null;

    [ContextMenu("Clear DirectInput log")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearLog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeWheelData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ComputeFeedbackForce(
      VehicleBase.WheelState wheel,
      VPDeviceInput.WheelData wheelData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessForceFeedback(int steerableWheels) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetG29ControllerInput(ref VPDeviceInput.ControllerInput controllerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessG29Gears(int[] inputData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ParseG29ForceFeedback(ref float forceFactor, ref float damperFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetG29ButtonDown(VPDeviceInput.G29Buttons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetG29ButtonUp(VPDeviceInput.G29Buttons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetG29Button(VPDeviceInput.G29Buttons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetG29DpadDirection(VPDeviceInput.G29Buttons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetG27ControllerInput(ref VPDeviceInput.ControllerInput controllerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessG27Gears(int[] inputData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ParseG27ForceFeedback(ref float forceFactor, ref float damperFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetG27ButtonDown(VPDeviceInput.G27Buttons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetG27ButtonUp(VPDeviceInput.G27Buttons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetG27Button(VPDeviceInput.G27Buttons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetG27DpadDirection(VPDeviceInput.G27Buttons button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetTMControllerInput(ref VPDeviceInput.ControllerInput controllerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessTMGears(int[] inputData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ParseTMForceFeedback(ref float forceFactor, ref float damperFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetFanatecDd2ControllerInput(ref VPDeviceInput.ControllerInput controllerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessFanatecDd2Gears(int[] inputData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ParseFanatecDd2ForceFeedback(ref float forceFactor, ref float damperFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetButtonDown(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetButtonUp(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetButton(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetPovDown(int directionDegrees, int pov = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetPovUp(int directionDegrees, int pov = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetPov(int directionDegrees, int pov = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetPovDownNonStrict(int directionDegrees, int pov = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetPovUpNonStrict(int directionDegrees, int pov = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetPovNonStrict(int directionDegrees, int pov = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetWheelValue(int rawValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetPedalValue(int rawValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetHalfPedalValue(int rawValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float EffectivePedalRange(float value, float rangeMin, float rangeMax) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPDeviceInput() => throw null;

    public enum DeviceModel
    {
      LogitechG27,
      Thrustmaster,
      LogitechG29,
      FanatecPodiumWheelBaseDD2,
    }

    public enum IgnitionKey
    {
      Off = -1, // 0xFFFFFFFF
      AccOn = 0,
    }

    public enum AutomaticGear
    {
      M,
      P,
      R,
      N,
      D,
      L,
    }

    public enum G27Buttons
    {
      None = -1, // 0xFFFFFFFF
      ShifterButton1 = 0,
      ShifterButton2 = 1,
      ShifterButton3 = 2,
      ShifterButton4 = 3,
      PaddleShifterRight = 4,
      PaddleShifterLeft = 5,
      WheelButtonRight1 = 6,
      WheelButtonLeft1 = 7,
      ShifterButtonUp = 15, // 0x0000000F
      ShifterButtonLeft = 16, // 0x00000010
      ShifterButtonDown = 17, // 0x00000011
      ShifterButtonRight = 18, // 0x00000012
      WheelButtonRight2 = 19, // 0x00000013
      WheelButtonLeft2 = 20, // 0x00000014
      WheelButtonRight3 = 21, // 0x00000015
      WheelButtonLeft3 = 22, // 0x00000016
      ShifterDpadNorth = 100, // 0x00000064
      ShifterDpadSouth = 101, // 0x00000065
      ShifterDpadEast = 102, // 0x00000066
      ShifterDpadWest = 103, // 0x00000067
      ShifterDpadAnyNorth = 104, // 0x00000068
      ShifterDpadAnySouth = 105, // 0x00000069
      ShifterDpadAnyEast = 106, // 0x0000006A
      ShifterDpadAnyWest = 107, // 0x0000006B
    }

    public enum G29Buttons
    {
      None = -1, // 0xFFFFFFFF
      Cross = 0,
      Square = 1,
      Circle = 2,
      Triangle = 3,
      GearUp = 4,
      GearDown = 5,
      R2 = 6,
      L2 = 7,
      Share = 8,
      Option = 9,
      R3 = 10, // 0x0000000A
      L3 = 11, // 0x0000000B
      Plus = 19, // 0x00000013
      Minus = 20, // 0x00000014
      DialRight = 21, // 0x00000015
      DialLeft = 22, // 0x00000016
      Enter = 23, // 0x00000017
      Playstation = 24, // 0x00000018
      DpadNorth = 100, // 0x00000064
      DpadSouth = 101, // 0x00000065
      DpadEast = 102, // 0x00000066
      DpadWest = 103, // 0x00000067
      DpadAnyNorth = 104, // 0x00000068
      DpadAnySouth = 105, // 0x00000069
      DpadAnyEast = 106, // 0x0000006A
      DpadAnyWest = 107, // 0x0000006B
    }

    private class WheelData
    {
      public float selfAlignmentTorque;
      public float weightRatio;
      public float gripRatio;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WheelData() => throw null;
    }

    private struct ControllerInput
    {
      public float steer;
      public float throttle;
      public float brake;
      public float clutch;
      public bool handbrake;
      public bool parkingBrakeToggle;
      public bool ignitionKeyOnDown;
      public bool ignitionKeyOnUp;
      public bool ignitionKeyOff;
    }
  }
}
