// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.FlightInputHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.FX.LaunchSystems;
using KSP.Input;
using KSP.Inspector;
using KSP.Sim.State;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class FlightInputHandler : FlightInputHandlerBase
  {
    private const float INPUT_TOLERANCE = 1E-05f;
    private GameInput.FlightActions _flightInputMap;
    private FlightInputDefinition _inputDefinition;
    private bool _modifierTriggered;
    private bool _hotkeyModifierTriggered;
    private bool _trimModifierTriggered;
    private bool _trimResetTriggered;
    private bool _stagingTriggered;
    private bool _interactTriggered;
    private bool _interactAltTriggered;
    private bool _interactAlt2Triggered;
    private bool _prelaunchThrottleSet;
    private float _inputTranslateX;
    private float _inputTranslateY;
    private float _inputTranslateZ;
    private float _inputYaw;
    private float _inputPitch;
    private float _inputRoll;
    private float _inputWheelSteer;
    private float _inputWheelThrottle;
    private float _inputThrottle;
    [ReadOnly]
    [SerializeField]
    private bool _isPrecisionMode;
    private static bool _overrideFlightCtrl;
    private static bool _overrideStagingCtrl;

    public bool IsPrecisionMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFlightControlState(float deltaTime, VesselComponent activeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFlightControlOverride(float inputSensitivityScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyManualInputToFlightControlState(float deltaTime, float inputSensitivityScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetFlightControlStateTrim() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyInputToFlightControlStateTrim(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AssignInputToFlightControlStateInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyInputToFlightControlState(float inputSensitivityScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetFlightControlStateInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMainThrottle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OverrideInputYaw(float newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OverrideInputPitch(float newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OverrideInputRoll(float newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OverrideInputTranslateX(float newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OverrideInputTranslateY(float newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OverrideInputTranslateZ(float newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OverrideInputWheelSteering(float newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OverrideInputStage(bool newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OverrideInputThrottle(float newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OverrideInputMaxThrottle(bool newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OverrideInputThrottleCutoff(bool newInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleLaunchStaging(
      ref FlightCtrlState FCS,
      bool isStageTriggered,
      VesselComponent vessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleInflightStaging(
      ref FlightCtrlState FCS,
      bool isStageTriggered,
      VesselComponent vessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandlePrelaunchInitiation(
      ref FlightCtrlState FCS,
      VesselComponent vessel,
      LaunchPadController launchpad)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleImmediateLaunch(
      ref FlightCtrlState FCS,
      bool isStageTriggered,
      VesselComponent vessel,
      LaunchPadController launchpad)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TogglePrecisionMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGamePadCursorEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCycleCameraMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTogglePrecisionMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup1() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup2() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup3() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup4() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup5() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup6() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup7() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup8() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup9() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup10() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeAltimeterMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeVelocityMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFocusNext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFocusPrev() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleSAS() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleRCS() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleLights() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWheelBrakes(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleLandingGear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleActionGroup(KSPActionGroup actionGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetActionGroup(KSPActionGroup actionGroup, bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleCameraZoom() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTranslateX(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTranslateY(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTranslateZ(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnYaw(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPitch(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRoll(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWheelSteer(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWheelThrottle(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnThrottleDelta(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnThrottleMax() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnThrottleCutoff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInteract(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInteractAlt(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInteractAlt2(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnModifier(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHotkeyModifier(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTrimModifier(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightInputHandler() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static FlightInputHandler() => throw null;
  }
}
