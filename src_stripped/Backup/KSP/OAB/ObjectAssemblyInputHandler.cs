// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyInputHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Input;
using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyInputHandler
  {
    private MessageCenter gameMessageCenter;
    private Vector2 keyBoardMovement;
    private ObjectAssemblyBuilderEvents eventsBuilder;
    private ObjectAssemblyUIEvents eventsUI;
    private OABSessionInformation stats;
    private ObjectAssemblyCameraManager cameraManager;
    private ObjectAssemblyPartTracker partTracker;
    private ObjectAssemblyBehaviorValues behaviorValues;
    public Transform previouslySelectedObject;
    public Transform currentlySelectedObject;
    public bool UIDeletionBlocked;
    private ObjectAssemblyAssets assets;
    private bool IsBlueprintOn;
    private float _speedMultiplier;
    private GameInput.OABActions _oabInputMap;
    private OabInputDefinition _inputDefinition;
    private bool _gamepadModifierTriggered;
    private RaycastHit[] _cameraRaycastHits;

    public bool MouseIsUnlocked
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 RightAxisDelta
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float CurrentZoomDelta
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector2 KeyboardMovement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public OABMouseActionType MouseLockedAction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Transform StageCenterTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    private ObjectAssemblyBuilderHUD oabHud
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private AssemblyPartsPicker partsPicker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float PlacementPlaneDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Plane PickupPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Plane DragPlane
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public DottedLine DottedLineObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartPositionInfo PartPositionInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsAltModifierActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsDisabledStackAttachment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsCtrlModifierActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsSpeedModifierActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    private IObjectAssemblyPart PartGrabbed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyInputHandler(
      ObjectAssemblyBuilderEvents eventsBuilder,
      ObjectAssemblyUIEvents eventsUI,
      OABSessionInformation stats,
      ObjectAssemblyCameraManager cameraManager,
      ObjectAssemblyAssets assets,
      ObjectAssemblyBehaviorValues behaviorValues,
      Transform stageCenter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUserBlueprintToggle(bool isBlueprintOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyPartTracker partTrackerToUse) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupInputMapping() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnbindInputs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAttemptToggleFavorite() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLockTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyAssets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleSnappingMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotatePitch(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotateYaw(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotateRoll(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotatePart(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMousePrimaryCanceled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMousePrimaryDoubleclick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseSecondary(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseSecondaryDoubleclick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseTertiary(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseTertiaryDoubleClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraFastModifier(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnModifierAlt(bool isActivated) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisableStackAttachment(bool isActivated) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnModifierCtrl(bool isActivated) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPaste() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSearch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToolNumbers(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraRotate(Vector2 direction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResetCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleConsoleToolbox() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSelectNextFilter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSelectNextCategory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnQuickSelectMode(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraPan(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraPanGamepad(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraZoom(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraZoomGamepad(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleFrameOfReference() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResetPartRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSelectAllPrimaryAssembly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateHovered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCursor(OABCursorType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCursor(Sprite sprite) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Ray GetCameraRay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetScreenSpaceCursorPositionInPixels() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetWorldSpaceCursorPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetWorldSpaceCursorPosition(
      out RaycastHit hitInfo,
      out IObjectAssemblyPart hitPart,
      bool hitClosestCollider = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetWorldSpaceCursorNormal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanConnectBasedOnSymmetrySet(IObjectAssemblyPart part, IObjectAssemblyPart setPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RaycastValidParts(
      out RaycastHit hitInfo,
      out IObjectAssemblyPart hitPart,
      bool hitClosesCollider = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsPartBeingHeld(Collider collider) => throw null;
  }
}
