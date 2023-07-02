// Decompiled with JetBrains decompiler
// Type: KSP.Input.FlightInputDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

namespace KSP.Input
{
  public class FlightInputDefinition : InputDefinition
  {
    private const string DOCKING_CONTROLS_MESSAGE = "Flight/FlightControlsDocking";
    private const string NORMAL_CONTROLS_MESSAGE = "Flight/FlightControlsNormal";
    private GameInput.FlightActions _inputSourceMap;
    private bool _isRotationLinearControlsSwapped;

    public override InputActionMap InputSourceMap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightInputDefinition(GameInput inputSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeActionBinders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCycleCameraMode(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTogglePrecisionMode(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup1(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup2(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup3(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup4(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup5(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup6(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup7(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup8(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup9(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTriggerActionGroup10(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleRotLinControls(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeALT(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeVEL(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFocusNext(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFocusPrev(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleSAS(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleRCS(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleLights(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWheelBrakes(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleLandingGear(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleCameraZoom(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStage(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTranslateX(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTranslateY(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTranslateZ(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnYaw(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPitch(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRoll(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWheelSteer(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWheelThrottle(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnThrottleDelta(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnThrottleMax(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnThrottleCutoff(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInteract(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInteractAlt(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInteractAlt2(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnModifier(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHotkeyModifier(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTrimModifier(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraFineMovement(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleAeroGUI(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraYawGamepad(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraPitchGamepad(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShowMap(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseSecondaryTap(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseDoubleTap(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouselook(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraPan(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleVesselLabels(InputAction.CallbackContext context) => throw null;
  }
}
