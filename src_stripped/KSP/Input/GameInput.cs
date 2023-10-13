// Decompiled with JetBrains decompiler
// Type: KSP.Input.GameInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace KSP.Input
{
  public class GameInput : 
    IInputActionCollection2,
    IInputActionCollection,
    IEnumerable<InputAction>,
    IEnumerable,
    IDisposable
  {
    private readonly InputActionMap m_Flight;
    private List<GameInput.IFlightActions> m_FlightActionsCallbackInterfaces;
    private readonly InputAction m_Flight_Pitch;
    private readonly InputAction m_Flight_Yaw;
    private readonly InputAction m_Flight_Roll;
    private readonly InputAction m_Flight_TranslateX;
    private readonly InputAction m_Flight_TranslateY;
    private readonly InputAction m_Flight_TranslateZ;
    private readonly InputAction m_Flight_ToggleRotLinControls;
    private readonly InputAction m_Flight_TogglePrecisionMode;
    private readonly InputAction m_Flight_TrimModifier;
    private readonly InputAction m_Flight_ThrottleDelta;
    private readonly InputAction m_Flight_ThrottleMax;
    private readonly InputAction m_Flight_ThrottleCutoff;
    private readonly InputAction m_Flight_Stage;
    private readonly InputAction m_Flight_ToggleSAS;
    private readonly InputAction m_Flight_ToggleRCS;
    private readonly InputAction m_Flight_ToggleLandingGear;
    private readonly InputAction m_Flight_WheelBrakes;
    private readonly InputAction m_Flight_ToggleLights;
    private readonly InputAction m_Flight_TriggerActionGroup1;
    private readonly InputAction m_Flight_TriggerActionGroup2;
    private readonly InputAction m_Flight_TriggerActionGroup3;
    private readonly InputAction m_Flight_TriggerActionGroup4;
    private readonly InputAction m_Flight_TriggerActionGroup5;
    private readonly InputAction m_Flight_TriggerActionGroup6;
    private readonly InputAction m_Flight_TriggerActionGroup7;
    private readonly InputAction m_Flight_TriggerActionGroup8;
    private readonly InputAction m_Flight_TriggerActionGroup9;
    private readonly InputAction m_Flight_TriggerActionGroup10;
    private readonly InputAction m_Flight_ShowMap;
    private readonly InputAction m_Flight_FocusNext;
    private readonly InputAction m_Flight_FocusPrev;
    private readonly InputAction m_Flight_CycleCameraMode;
    private readonly InputAction m_Flight_CameraFineMovement;
    private readonly InputAction m_Flight_changeALT;
    private readonly InputAction m_Flight_changeVEL;
    private readonly InputAction m_Flight_modifier;
    private readonly InputAction m_Flight_hotKeyModifier;
    private readonly InputAction m_Flight_WheelSteer;
    private readonly InputAction m_Flight_ActiveFuncitonMenu;
    private readonly InputAction m_Flight_ActiveSASLastUse;
    private readonly InputAction m_Flight_toggleCameraZoom;
    private readonly InputAction m_Flight_ToggleAeroGUI;
    private readonly InputAction m_Flight_mouseSecondaryTap;
    private readonly InputAction m_Flight_mouseDoubleTap;
    private readonly InputAction m_Flight_CameraYawGamepad;
    private readonly InputAction m_Flight_CameraPitchGamepad;
    private readonly InputAction m_Flight_cameraPan;
    private readonly InputAction m_Flight_WheelThrottle;
    private readonly InputAction m_Flight_ToggleMouselook;
    private readonly InputAction m_Flight_Interact;
    private readonly InputAction m_Flight_InteractAlt;
    private readonly InputAction m_Flight_InteractAlt2;
    private readonly InputAction m_Flight_ToggleVesselLabels;
    private readonly InputAction m_Flight_CameraZoom;
    private readonly InputAction m_Flight_ToggleFreeCamera;
    private readonly InputActionMap m_Global;
    private List<GameInput.IGlobalActions> m_GlobalActionsCallbackInterfaces;
    private readonly InputAction m_Global_QuickSave;
    private readonly InputAction m_Global_QuickLoad;
    private readonly InputAction m_Global_QuickLoadHold;
    private readonly InputAction m_Global_TimeWarpIncrease;
    private readonly InputAction m_Global_TimeWarpDecrease;
    private readonly InputAction m_Global_TimeWarpStop;
    private readonly InputAction m_Global_TogglePauseMenu;
    private readonly InputAction m_Global_TogglePartsManager;
    private readonly InputAction m_Global_ToggleDebugWindow;
    private readonly InputAction m_Global_ToggleDebugMPWindow;
    private readonly InputAction m_Global_ToggleInGameMPWindow;
    private readonly InputAction m_Global_ToggleDebugKeyShowAssetName;
    private readonly InputAction m_Global_ToggleDebugAudio;
    private readonly InputAction m_Global_ToggleUIVisibility;
    private readonly InputAction m_Global_MenuGoBack;
    private readonly InputAction m_Global_ExpandTooltip;
    private readonly InputAction m_Global_FreezeTooltip;
    private readonly InputAction m_Global_OpenContextPanel;
    private readonly InputAction m_Global_ToggleBiomeDebugView;
    private readonly InputAction m_Global_ConfirmDialogue;
    private readonly InputAction m_Global_SkipSplashScreen;
    private readonly InputActionMap m_EVA;
    private List<GameInput.IEVAActions> m_EVAActionsCallbackInterfaces;
    private readonly InputAction m_EVA_MoveLeftRight;
    private readonly InputAction m_EVA_MoveStrafeLeftRight;
    private readonly InputAction m_EVA_MoveFrontBack;
    private readonly InputAction m_EVA_MoveUpDown;
    private readonly InputAction m_EVA_RotateYaw;
    private readonly InputAction m_EVA_RotatePitch;
    private readonly InputAction m_EVA_RotateRoll;
    private readonly InputAction m_EVA_Run;
    private readonly InputAction m_EVA_Jump;
    private readonly InputActionMap m_VAB;
    private List<GameInput.IVABActions> m_VABActionsCallbackInterfaces;
    private readonly InputAction m_VAB_delete;
    private readonly InputAction m_VAB_nextSymmetryMode;
    private readonly InputAction m_VAB_previousSymmetryMode;
    private readonly InputAction m_VAB_toggleAngleSnap;
    private readonly InputAction m_VAB_disableStackAttachment;
    private readonly InputAction m_VAB_resetPartRotation;
    private readonly InputAction m_VAB_resetCamera;
    private readonly InputAction m_VAB_hotKeyModifier;
    private readonly InputAction m_VAB_modifier;
    private readonly InputAction m_VAB_fastScrollModifier;
    private readonly InputAction m_VAB_copy;
    private readonly InputAction m_VAB_search;
    private readonly InputAction m_VAB_paste;
    private readonly InputAction m_VAB_undo;
    private readonly InputAction m_VAB_redo;
    private readonly InputAction m_VAB_toolMove;
    private readonly InputAction m_VAB_cameraPan;
    private readonly InputAction m_VAB_cameraFastModifier;
    private readonly InputAction m_VAB_cameraLook;
    private readonly InputAction m_VAB_cameraRotate;
    private readonly InputAction m_VAB_cameraZoom;
    private readonly InputAction m_VAB_toolMoveUpDown;
    private readonly InputAction m_VAB_toolNumbers;
    private readonly InputAction m_VAB_mousePrimary;
    private readonly InputAction m_VAB_mouseSecondary;
    private readonly InputAction m_VAB_mouseTertiary;
    private readonly InputAction m_VAB_testSave;
    private readonly InputAction m_VAB_testLoad;
    private readonly InputAction m_VAB_rotatePitch;
    private readonly InputAction m_VAB_rotateYaw;
    private readonly InputAction m_VAB_rotateRoll;
    private readonly InputAction m_VAB_setSymmetryMirrorMode;
    private readonly InputAction m_VAB_addFavorite;
    private readonly InputAction m_VAB_lockTarget;
    private readonly InputAction m_VAB_quitOrthoView;
    private readonly InputAction m_VAB_toggleConsoleToolbox;
    private readonly InputAction m_VAB_blueprintModeGamepad;
    private readonly InputAction m_VAB_launch;
    private readonly InputAction m_VAB_modifierGamepad;
    private readonly InputAction m_VAB_cameraZoomGamepad;
    private readonly InputAction m_VAB_cameraPanGamepad;
    private readonly InputAction m_VAB_rotatePartGamepad;
    private readonly InputAction m_VAB_toggleFilterGamepad;
    private readonly InputAction m_VAB_toggleCategoriesGamepad;
    private readonly InputAction m_VAB_toggleFrameOfReference;
    private readonly InputAction m_VAB_selectAllPrimaryAssembly;
    private readonly InputAction m_VAB_tooltipPageDown;
    private readonly InputAction m_VAB_tooltipPageUp;
    private readonly InputActionMap m_MapView;
    private List<GameInput.IMapViewActions> m_MapViewActionsCallbackInterfaces;
    private readonly InputAction m_MapView_mousePosition;
    private readonly InputAction m_MapView_mousePrimary;
    private readonly InputAction m_MapView_mouseSecondary;
    private readonly InputAction m_MapView_mouseTertiary;
    private readonly InputAction m_MapView_resetCamera;
    private readonly InputAction m_MapView_cameraMoveXY;
    private readonly InputAction m_MapView_altKeyModifier;
    private readonly InputAction m_MapView_ctrlKeyModifier;
    private readonly InputAction m_MapView_cameraRotate;
    private readonly InputAction m_MapView_nextMapItem;
    private readonly InputAction m_MapView_previousMapItem;
    private readonly InputAction m_MapView_cameraZoom;
    private readonly InputAction m_MapView_HideMap;
    private readonly InputAction m_MapView_changeALT;
    private readonly InputAction m_MapView_changeVEL;
    private readonly InputAction m_MapView_Focus;
    private readonly InputActionMap m_RD;
    private List<GameInput.IRDActions> m_RDActionsCallbackInterfaces;
    private readonly InputAction m_RD_cameraZoom;
    private readonly InputAction m_RD_mousePosition;
    private readonly InputAction m_RD_cameraMovement;
    private readonly InputAction m_RD_cameraDragMouse;
    private readonly InputAction m_RD_expandPartInfoTooltip;
    private readonly InputActionMap m_Cursor;
    private List<GameInput.ICursorActions> m_CursorActionsCallbackInterfaces;
    private readonly InputAction m_Cursor_LeftStick;
    private readonly InputAction m_Cursor_LeftClick;
    private readonly InputAction m_Cursor_LeftDoubleTap;
    private readonly InputAction m_Cursor_RightClick;
    private readonly InputAction m_Cursor_RightDoubleTap;
    private readonly InputAction m_Cursor_MiddleClick;
    private readonly InputAction m_Cursor_MiddleDoubleTap;
    private readonly InputAction m_Cursor_LeftClickGamepad;
    private readonly InputAction m_Cursor_LeftDoubleTapGamepad;
    private readonly InputActionMap m_Navigation_Move_DPad;
    private List<GameInput.INavigation_Move_DPadActions> m_Navigation_Move_DPadActionsCallbackInterfaces;
    private readonly InputAction m_Navigation_Move_DPad_MoveUp;
    private readonly InputAction m_Navigation_Move_DPad_MoveDown;
    private readonly InputAction m_Navigation_Move_DPad_MoveLeft;
    private readonly InputAction m_Navigation_Move_DPad_MoveRight;
    private readonly InputActionMap m_Navigation_Move_LeftStick;
    private List<GameInput.INavigation_Move_LeftStickActions> m_Navigation_Move_LeftStickActionsCallbackInterfaces;
    private readonly InputAction m_Navigation_Move_LeftStick_MoveUp;
    private readonly InputAction m_Navigation_Move_LeftStick_MoveDown;
    private readonly InputAction m_Navigation_Move_LeftStick_MoveLeft;
    private readonly InputAction m_Navigation_Move_LeftStick_MoveRight;
    private readonly InputActionMap m_Navigation_Submit;
    private List<GameInput.INavigation_SubmitActions> m_Navigation_SubmitActionsCallbackInterfaces;
    private readonly InputAction m_Navigation_Submit_Submit;
    private readonly InputAction m_Navigation_Submit_HoldSubmit;
    private readonly InputActionMap m_Navigation_Quit;
    private List<GameInput.INavigation_QuitActions> m_Navigation_QuitActionsCallbackInterfaces;
    private readonly InputAction m_Navigation_Quit_Quit;
    private readonly InputActionMap m_Navigation_Scroll;
    private List<GameInput.INavigation_ScrollActions> m_Navigation_ScrollActionsCallbackInterfaces;
    private readonly InputAction m_Navigation_Scroll_Scroll;
    private readonly InputActionMap m_ConsoleToolbox;
    private List<GameInput.IConsoleToolboxActions> m_ConsoleToolboxActionsCallbackInterfaces;
    private readonly InputAction m_ConsoleToolbox_Hide;
    private readonly InputActionMap m_Navigation_Slider;
    private List<GameInput.INavigation_SliderActions> m_Navigation_SliderActionsCallbackInterfaces;
    private readonly InputAction m_Navigation_Slider_Value;
    private readonly InputAction m_Navigation_Slider_Submit;
    private readonly InputAction m_Navigation_Slider_Cancel;
    private readonly InputActionMap m_KSC;
    private List<GameInput.IKSCActions> m_KSCActionsCallbackInterfaces;
    private readonly InputAction m_KSC_ShowMap;
    private readonly InputAction m_KSC_CameraZoom;
    private readonly InputActionMap m_Audio;
    private List<GameInput.IAudioActions> m_AudioActionsCallbackInterfaces;
    private readonly InputAction m_Audio_MuteGame;
    private readonly InputAction m_Audio_MuteMusic;
    private int m_GamePadSchemeIndex;
    private int m_KeyboardSchemeIndex;
    private int m_HideSchemeIndex;

    public InputActionAsset asset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    public InputBinding? bindingMask
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Contains(InputAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<InputAction> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Enable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Disable() => throw null;

    public IEnumerable<InputBinding> bindings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FindBinding(InputBinding bindingMask, out InputAction action) => throw null;

    public GameInput.FlightActions Flight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.GlobalActions Global
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.EVAActions EVA
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.VABActions VAB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.MapViewActions MapView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.RDActions RD
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.CursorActions Cursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.Navigation_Move_DPadActions Navigation_Move_DPad
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.Navigation_Move_LeftStickActions Navigation_Move_LeftStick
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.Navigation_SubmitActions Navigation_Submit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.Navigation_QuitActions Navigation_Quit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.Navigation_ScrollActions Navigation_Scroll
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.ConsoleToolboxActions ConsoleToolbox
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.Navigation_SliderActions Navigation_Slider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.KSCActions KSC
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInput.AudioActions Audio
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public InputControlScheme GamePadScheme
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public InputControlScheme KeyboardScheme
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public InputControlScheme HideScheme
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public struct FlightActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public FlightActions(GameInput wrapper) => throw null;

      public InputAction Pitch
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction Yaw
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction Roll
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TranslateX
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TranslateY
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TranslateZ
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleRotLinControls
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TogglePrecisionMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TrimModifier
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ThrottleDelta
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ThrottleMax
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ThrottleCutoff
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction Stage
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleSAS
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleRCS
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleLandingGear
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction WheelBrakes
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleLights
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TriggerActionGroup1
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TriggerActionGroup2
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TriggerActionGroup3
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TriggerActionGroup4
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TriggerActionGroup5
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TriggerActionGroup6
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TriggerActionGroup7
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TriggerActionGroup8
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TriggerActionGroup9
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TriggerActionGroup10
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ShowMap
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction FocusNext
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction FocusPrev
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction CycleCameraMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction CameraFineMovement
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction changeALT
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction changeVEL
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction modifier
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction hotKeyModifier
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction WheelSteer
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ActiveFuncitonMenu
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ActiveSASLastUse
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction toggleCameraZoom
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleAeroGUI
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction mouseSecondaryTap
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction mouseDoubleTap
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction CameraYawGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction CameraPitchGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraPan
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction WheelThrottle
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleMouselook
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction Interact
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction InteractAlt
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction InteractAlt2
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleVesselLabels
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction CameraZoom
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleFreeCamera
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.FlightActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.IFlightActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.IFlightActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.IFlightActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.IFlightActions instance) => throw null;
    }

    public struct GlobalActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public GlobalActions(GameInput wrapper) => throw null;

      public InputAction QuickSave
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction QuickLoad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction QuickLoadHold
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TimeWarpIncrease
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TimeWarpDecrease
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TimeWarpStop
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TogglePauseMenu
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction TogglePartsManager
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleDebugWindow
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleDebugMPWindow
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleInGameMPWindow
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleDebugKeyShowAssetName
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleDebugAudio
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleUIVisibility
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MenuGoBack
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ExpandTooltip
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction FreezeTooltip
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction OpenContextPanel
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ToggleBiomeDebugView
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ConfirmDialogue
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction SkipSplashScreen
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.GlobalActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.IGlobalActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.IGlobalActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.IGlobalActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.IGlobalActions instance) => throw null;
    }

    public struct EVAActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EVAActions(GameInput wrapper) => throw null;

      public InputAction MoveLeftRight
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MoveStrafeLeftRight
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MoveFrontBack
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MoveUpDown
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction RotateYaw
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction RotatePitch
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction RotateRoll
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction Run
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction Jump
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.EVAActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.IEVAActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.IEVAActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.IEVAActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.IEVAActions instance) => throw null;
    }

    public struct VABActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public VABActions(GameInput wrapper) => throw null;

      public InputAction delete
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction nextSymmetryMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction previousSymmetryMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction toggleAngleSnap
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction disableStackAttachment
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction resetPartRotation
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction resetCamera
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction hotKeyModifier
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction modifier
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction fastScrollModifier
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction copy
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction search
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction paste
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction undo
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction redo
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction toolMove
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraPan
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraFastModifier
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraLook
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraRotate
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraZoom
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction toolMoveUpDown
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction toolNumbers
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction mousePrimary
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction mouseSecondary
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction mouseTertiary
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction testSave
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction testLoad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction rotatePitch
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction rotateYaw
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction rotateRoll
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction setSymmetryMirrorMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction addFavorite
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction lockTarget
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction quitOrthoView
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction toggleConsoleToolbox
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction blueprintModeGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction launch
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction modifierGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraZoomGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraPanGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction rotatePartGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction toggleFilterGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction toggleCategoriesGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction toggleFrameOfReference
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction selectAllPrimaryAssembly
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction tooltipPageDown
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction tooltipPageUp
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.VABActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.IVABActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.IVABActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.IVABActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.IVABActions instance) => throw null;
    }

    public struct MapViewActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public MapViewActions(GameInput wrapper) => throw null;

      public InputAction mousePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction mousePrimary
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction mouseSecondary
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction mouseTertiary
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction resetCamera
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraMoveXY
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction altKeyModifier
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction ctrlKeyModifier
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraRotate
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction nextMapItem
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction previousMapItem
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraZoom
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction HideMap
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction changeALT
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction changeVEL
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction Focus
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.MapViewActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.IMapViewActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.IMapViewActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.IMapViewActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.IMapViewActions instance) => throw null;
    }

    public struct RDActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public RDActions(GameInput wrapper) => throw null;

      public InputAction cameraZoom
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction mousePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraMovement
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction cameraDragMouse
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction expandPartInfoTooltip
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.RDActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.IRDActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.IRDActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.IRDActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.IRDActions instance) => throw null;
    }

    public struct CursorActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CursorActions(GameInput wrapper) => throw null;

      public InputAction LeftStick
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction LeftClick
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction LeftDoubleTap
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction RightClick
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction RightDoubleTap
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MiddleClick
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MiddleDoubleTap
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction LeftClickGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction LeftDoubleTapGamepad
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.CursorActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.ICursorActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.ICursorActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.ICursorActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.ICursorActions instance) => throw null;
    }

    public struct Navigation_Move_DPadActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Navigation_Move_DPadActions(GameInput wrapper) => throw null;

      public InputAction MoveUp
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MoveDown
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MoveLeft
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MoveRight
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.Navigation_Move_DPadActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.INavigation_Move_DPadActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.INavigation_Move_DPadActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.INavigation_Move_DPadActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.INavigation_Move_DPadActions instance) => throw null;
    }

    public struct Navigation_Move_LeftStickActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Navigation_Move_LeftStickActions(GameInput wrapper) => throw null;

      public InputAction MoveUp
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MoveDown
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MoveLeft
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MoveRight
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.Navigation_Move_LeftStickActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(
        GameInput.INavigation_Move_LeftStickActions instance)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(
        GameInput.INavigation_Move_LeftStickActions instance)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(
        GameInput.INavigation_Move_LeftStickActions instance)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(
        GameInput.INavigation_Move_LeftStickActions instance)
      {
        throw null;
      }
    }

    public struct Navigation_SubmitActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Navigation_SubmitActions(GameInput wrapper) => throw null;

      public InputAction Submit
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction HoldSubmit
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.Navigation_SubmitActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.INavigation_SubmitActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.INavigation_SubmitActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.INavigation_SubmitActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.INavigation_SubmitActions instance) => throw null;
    }

    public struct Navigation_QuitActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Navigation_QuitActions(GameInput wrapper) => throw null;

      public InputAction Quit
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.Navigation_QuitActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.INavigation_QuitActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.INavigation_QuitActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.INavigation_QuitActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.INavigation_QuitActions instance) => throw null;
    }

    public struct Navigation_ScrollActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Navigation_ScrollActions(GameInput wrapper) => throw null;

      public InputAction Scroll
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.Navigation_ScrollActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.INavigation_ScrollActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.INavigation_ScrollActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.INavigation_ScrollActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.INavigation_ScrollActions instance) => throw null;
    }

    public struct ConsoleToolboxActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ConsoleToolboxActions(GameInput wrapper) => throw null;

      public InputAction Hide
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.ConsoleToolboxActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.IConsoleToolboxActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.IConsoleToolboxActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.IConsoleToolboxActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.IConsoleToolboxActions instance) => throw null;
    }

    public struct Navigation_SliderActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Navigation_SliderActions(GameInput wrapper) => throw null;

      public InputAction Value
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction Submit
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction Cancel
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.Navigation_SliderActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.INavigation_SliderActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.INavigation_SliderActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.INavigation_SliderActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.INavigation_SliderActions instance) => throw null;
    }

    public struct KSCActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public KSCActions(GameInput wrapper) => throw null;

      public InputAction ShowMap
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction CameraZoom
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.KSCActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.IKSCActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.IKSCActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.IKSCActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.IKSCActions instance) => throw null;
    }

    public struct AudioActions
    {
      private GameInput m_Wrapper;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AudioActions(GameInput wrapper) => throw null;

      public InputAction MuteGame
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public InputAction MuteMusic
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputActionMap Get() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Enable() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Disable() => throw null;

      public bool enabled
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static implicit operator InputActionMap(GameInput.AudioActions set) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddCallbacks(GameInput.IAudioActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void UnregisterCallbacks(GameInput.IAudioActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveCallbacks(GameInput.IAudioActions instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCallbacks(GameInput.IAudioActions instance) => throw null;
    }

    public interface IFlightActions
    {
      void OnPitch(InputAction.CallbackContext context);

      void OnYaw(InputAction.CallbackContext context);

      void OnRoll(InputAction.CallbackContext context);

      void OnTranslateX(InputAction.CallbackContext context);

      void OnTranslateY(InputAction.CallbackContext context);

      void OnTranslateZ(InputAction.CallbackContext context);

      void OnToggleRotLinControls(InputAction.CallbackContext context);

      void OnTogglePrecisionMode(InputAction.CallbackContext context);

      void OnTrimModifier(InputAction.CallbackContext context);

      void OnThrottleDelta(InputAction.CallbackContext context);

      void OnThrottleMax(InputAction.CallbackContext context);

      void OnThrottleCutoff(InputAction.CallbackContext context);

      void OnStage(InputAction.CallbackContext context);

      void OnToggleSAS(InputAction.CallbackContext context);

      void OnToggleRCS(InputAction.CallbackContext context);

      void OnToggleLandingGear(InputAction.CallbackContext context);

      void OnWheelBrakes(InputAction.CallbackContext context);

      void OnToggleLights(InputAction.CallbackContext context);

      void OnTriggerActionGroup1(InputAction.CallbackContext context);

      void OnTriggerActionGroup2(InputAction.CallbackContext context);

      void OnTriggerActionGroup3(InputAction.CallbackContext context);

      void OnTriggerActionGroup4(InputAction.CallbackContext context);

      void OnTriggerActionGroup5(InputAction.CallbackContext context);

      void OnTriggerActionGroup6(InputAction.CallbackContext context);

      void OnTriggerActionGroup7(InputAction.CallbackContext context);

      void OnTriggerActionGroup8(InputAction.CallbackContext context);

      void OnTriggerActionGroup9(InputAction.CallbackContext context);

      void OnTriggerActionGroup10(InputAction.CallbackContext context);

      void OnShowMap(InputAction.CallbackContext context);

      void OnFocusNext(InputAction.CallbackContext context);

      void OnFocusPrev(InputAction.CallbackContext context);

      void OnCycleCameraMode(InputAction.CallbackContext context);

      void OnCameraFineMovement(InputAction.CallbackContext context);

      void OnChangeALT(InputAction.CallbackContext context);

      void OnChangeVEL(InputAction.CallbackContext context);

      void OnModifier(InputAction.CallbackContext context);

      void OnHotKeyModifier(InputAction.CallbackContext context);

      void OnWheelSteer(InputAction.CallbackContext context);

      void OnActiveFuncitonMenu(InputAction.CallbackContext context);

      void OnActiveSASLastUse(InputAction.CallbackContext context);

      void OnToggleCameraZoom(InputAction.CallbackContext context);

      void OnToggleAeroGUI(InputAction.CallbackContext context);

      void OnMouseSecondaryTap(InputAction.CallbackContext context);

      void OnMouseDoubleTap(InputAction.CallbackContext context);

      void OnCameraYawGamepad(InputAction.CallbackContext context);

      void OnCameraPitchGamepad(InputAction.CallbackContext context);

      void OnCameraPan(InputAction.CallbackContext context);

      void OnWheelThrottle(InputAction.CallbackContext context);

      void OnToggleMouselook(InputAction.CallbackContext context);

      void OnInteract(InputAction.CallbackContext context);

      void OnInteractAlt(InputAction.CallbackContext context);

      void OnInteractAlt2(InputAction.CallbackContext context);

      void OnToggleVesselLabels(InputAction.CallbackContext context);

      void OnCameraZoom(InputAction.CallbackContext context);

      void OnToggleFreeCamera(InputAction.CallbackContext context);
    }

    public interface IGlobalActions
    {
      void OnQuickSave(InputAction.CallbackContext context);

      void OnQuickLoad(InputAction.CallbackContext context);

      void OnQuickLoadHold(InputAction.CallbackContext context);

      void OnTimeWarpIncrease(InputAction.CallbackContext context);

      void OnTimeWarpDecrease(InputAction.CallbackContext context);

      void OnTimeWarpStop(InputAction.CallbackContext context);

      void OnTogglePauseMenu(InputAction.CallbackContext context);

      void OnTogglePartsManager(InputAction.CallbackContext context);

      void OnToggleDebugWindow(InputAction.CallbackContext context);

      void OnToggleDebugMPWindow(InputAction.CallbackContext context);

      void OnToggleInGameMPWindow(InputAction.CallbackContext context);

      void OnToggleDebugKeyShowAssetName(InputAction.CallbackContext context);

      void OnToggleDebugAudio(InputAction.CallbackContext context);

      void OnToggleUIVisibility(InputAction.CallbackContext context);

      void OnMenuGoBack(InputAction.CallbackContext context);

      void OnExpandTooltip(InputAction.CallbackContext context);

      void OnFreezeTooltip(InputAction.CallbackContext context);

      void OnOpenContextPanel(InputAction.CallbackContext context);

      void OnToggleBiomeDebugView(InputAction.CallbackContext context);

      void OnConfirmDialogue(InputAction.CallbackContext context);

      void OnSkipSplashScreen(InputAction.CallbackContext context);
    }

    public interface IEVAActions
    {
      void OnMoveLeftRight(InputAction.CallbackContext context);

      void OnMoveStrafeLeftRight(InputAction.CallbackContext context);

      void OnMoveFrontBack(InputAction.CallbackContext context);

      void OnMoveUpDown(InputAction.CallbackContext context);

      void OnRotateYaw(InputAction.CallbackContext context);

      void OnRotatePitch(InputAction.CallbackContext context);

      void OnRotateRoll(InputAction.CallbackContext context);

      void OnRun(InputAction.CallbackContext context);

      void OnJump(InputAction.CallbackContext context);
    }

    public interface IVABActions
    {
      void OnDelete(InputAction.CallbackContext context);

      void OnNextSymmetryMode(InputAction.CallbackContext context);

      void OnPreviousSymmetryMode(InputAction.CallbackContext context);

      void OnToggleAngleSnap(InputAction.CallbackContext context);

      void OnDisableStackAttachment(InputAction.CallbackContext context);

      void OnResetPartRotation(InputAction.CallbackContext context);

      void OnResetCamera(InputAction.CallbackContext context);

      void OnHotKeyModifier(InputAction.CallbackContext context);

      void OnModifier(InputAction.CallbackContext context);

      void OnFastScrollModifier(InputAction.CallbackContext context);

      void OnCopy(InputAction.CallbackContext context);

      void OnSearch(InputAction.CallbackContext context);

      void OnPaste(InputAction.CallbackContext context);

      void OnUndo(InputAction.CallbackContext context);

      void OnRedo(InputAction.CallbackContext context);

      void OnToolMove(InputAction.CallbackContext context);

      void OnCameraPan(InputAction.CallbackContext context);

      void OnCameraFastModifier(InputAction.CallbackContext context);

      void OnCameraLook(InputAction.CallbackContext context);

      void OnCameraRotate(InputAction.CallbackContext context);

      void OnCameraZoom(InputAction.CallbackContext context);

      void OnToolMoveUpDown(InputAction.CallbackContext context);

      void OnToolNumbers(InputAction.CallbackContext context);

      void OnMousePrimary(InputAction.CallbackContext context);

      void OnMouseSecondary(InputAction.CallbackContext context);

      void OnMouseTertiary(InputAction.CallbackContext context);

      void OnTestSave(InputAction.CallbackContext context);

      void OnTestLoad(InputAction.CallbackContext context);

      void OnRotatePitch(InputAction.CallbackContext context);

      void OnRotateYaw(InputAction.CallbackContext context);

      void OnRotateRoll(InputAction.CallbackContext context);

      void OnSetSymmetryMirrorMode(InputAction.CallbackContext context);

      void OnAddFavorite(InputAction.CallbackContext context);

      void OnLockTarget(InputAction.CallbackContext context);

      void OnQuitOrthoView(InputAction.CallbackContext context);

      void OnToggleConsoleToolbox(InputAction.CallbackContext context);

      void OnBlueprintModeGamepad(InputAction.CallbackContext context);

      void OnLaunch(InputAction.CallbackContext context);

      void OnModifierGamepad(InputAction.CallbackContext context);

      void OnCameraZoomGamepad(InputAction.CallbackContext context);

      void OnCameraPanGamepad(InputAction.CallbackContext context);

      void OnRotatePartGamepad(InputAction.CallbackContext context);

      void OnToggleFilterGamepad(InputAction.CallbackContext context);

      void OnToggleCategoriesGamepad(InputAction.CallbackContext context);

      void OnToggleFrameOfReference(InputAction.CallbackContext context);

      void OnSelectAllPrimaryAssembly(InputAction.CallbackContext context);

      void OnTooltipPageDown(InputAction.CallbackContext context);

      void OnTooltipPageUp(InputAction.CallbackContext context);
    }

    public interface IMapViewActions
    {
      void OnMousePosition(InputAction.CallbackContext context);

      void OnMousePrimary(InputAction.CallbackContext context);

      void OnMouseSecondary(InputAction.CallbackContext context);

      void OnMouseTertiary(InputAction.CallbackContext context);

      void OnResetCamera(InputAction.CallbackContext context);

      void OnCameraMoveXY(InputAction.CallbackContext context);

      void OnAltKeyModifier(InputAction.CallbackContext context);

      void OnCtrlKeyModifier(InputAction.CallbackContext context);

      void OnCameraRotate(InputAction.CallbackContext context);

      void OnNextMapItem(InputAction.CallbackContext context);

      void OnPreviousMapItem(InputAction.CallbackContext context);

      void OnCameraZoom(InputAction.CallbackContext context);

      void OnHideMap(InputAction.CallbackContext context);

      void OnChangeALT(InputAction.CallbackContext context);

      void OnChangeVEL(InputAction.CallbackContext context);

      void OnFocus(InputAction.CallbackContext context);
    }

    public interface IRDActions
    {
      void OnCameraZoom(InputAction.CallbackContext context);

      void OnMousePosition(InputAction.CallbackContext context);

      void OnCameraMovement(InputAction.CallbackContext context);

      void OnCameraDragMouse(InputAction.CallbackContext context);

      void OnExpandPartInfoTooltip(InputAction.CallbackContext context);
    }

    public interface ICursorActions
    {
      void OnLeftStick(InputAction.CallbackContext context);

      void OnLeftClick(InputAction.CallbackContext context);

      void OnLeftDoubleTap(InputAction.CallbackContext context);

      void OnRightClick(InputAction.CallbackContext context);

      void OnRightDoubleTap(InputAction.CallbackContext context);

      void OnMiddleClick(InputAction.CallbackContext context);

      void OnMiddleDoubleTap(InputAction.CallbackContext context);

      void OnLeftClickGamepad(InputAction.CallbackContext context);

      void OnLeftDoubleTapGamepad(InputAction.CallbackContext context);
    }

    public interface INavigation_Move_DPadActions
    {
      void OnMoveUp(InputAction.CallbackContext context);

      void OnMoveDown(InputAction.CallbackContext context);

      void OnMoveLeft(InputAction.CallbackContext context);

      void OnMoveRight(InputAction.CallbackContext context);
    }

    public interface INavigation_Move_LeftStickActions
    {
      void OnMoveUp(InputAction.CallbackContext context);

      void OnMoveDown(InputAction.CallbackContext context);

      void OnMoveLeft(InputAction.CallbackContext context);

      void OnMoveRight(InputAction.CallbackContext context);
    }

    public interface INavigation_SubmitActions
    {
      void OnSubmit(InputAction.CallbackContext context);

      void OnHoldSubmit(InputAction.CallbackContext context);
    }

    public interface INavigation_QuitActions
    {
      void OnQuit(InputAction.CallbackContext context);
    }

    public interface INavigation_ScrollActions
    {
      void OnScroll(InputAction.CallbackContext context);
    }

    public interface IConsoleToolboxActions
    {
      void OnHide(InputAction.CallbackContext context);
    }

    public interface INavigation_SliderActions
    {
      void OnValue(InputAction.CallbackContext context);

      void OnSubmit(InputAction.CallbackContext context);

      void OnCancel(InputAction.CallbackContext context);
    }

    public interface IKSCActions
    {
      void OnShowMap(InputAction.CallbackContext context);

      void OnCameraZoom(InputAction.CallbackContext context);
    }

    public interface IAudioActions
    {
      void OnMuteGame(InputAction.CallbackContext context);

      void OnMuteMusic(InputAction.CallbackContext context);
    }
  }
}
