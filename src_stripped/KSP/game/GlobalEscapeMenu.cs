// Decompiled with JetBrains decompiler
// Type: KSP.Game.GlobalEscapeMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using KSP.Input;
using KSP.Logging;
using KSP.Messages;
using KSP.OAB;
using KSP.UI.Binding;
using KSP.UserInterface;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KSP.Game
{
  [PrefabName("EscapeMenu.prefab")]
  public class GlobalEscapeMenu : UIModule
  {
    private const string EXIT_WITHOUT_SAVING = "Menu/Escape/ExitWithoutSaving";
    private const string QUIT_MULTIPLAYER_SESSION = "Menu/Escape/QuitMultiplayerSession";
    private const string QUIT_MULTIPLAYER_SESSION_WARNING = "Menu/Escape/QuitMultiplayerSessionWarning";
    private const string QUIT_GAME_MULTIPLAYER_SESSION_WARNING = "Menu/Escape/QuitGameMultiplayerSessionWarning";
    private const string LEAVE_MULTIPLAYER_SESSION = "Menu/Escape/Leave Multiplayer Session";
    private const string LEAVE_MULTIPLAYER_SESSION_WARNING = "Menu/Escape/LeaveMultiplayerSessionWarning";
    private const string LEAVE = "Menu/Escape/Leave";
    private const string QUIT_READONLY_SESSION = "Menu/Escape/QuitReadOnlySession";
    private const string QUIT_READONLY_SESSION_WARNING = "Menu/Escape/QuitReadOnlySessionWarning";
    private const string QUIT = "Menu/Escape/Quit";
    private const string QUIT_GAME = "Menu/Escape/Quit Game";
    private const string EXIT = "Menu/Escape/Exit";
    private const string SAVE_AND_EXIT = "Menu/Escape/SaveAndExit";
    private const string SAVE_BEFORE_EXITING = "Menu/Escape/SaveBeforeExiting";
    private const string SAVE_BEFORE_EXITING_WARNING = "Menu/Escape/SaveBeforeExitingWarning";
    private const string SAVE_BEFORE_EXITING_GAME = "Menu/Escape/SaveBeforeExitingGame";
    private const string SAVE_BEFORE_EXITING_GAME_WARNING = "Menu/Escape/SaveBeforeExitingGameWarning";
    private const string NO_HOST_OR_CLIENT_WARNING = "Menu/Escape/NoHostOrClient";
    private const string NO_HOST_OR_CLIENT_WARNING_MP = "Menu/Escape/NoHostOrClientMP";
    private const string LAUNCHPAD = "Launchpad_1";
    private const string RUNWAY = "Runway_1";
    private const string CONFIRM_REVERT = "Menu/Escape/ConfirmRevert";
    private const string DONT_REVERT = "Menu/Escape/DontRevert";
    private const string REVERT_TO_LAUNCH_TITLE = "Menu/Escape/RevertToLaunchWarningModalTitle";
    private const string REVERT_TO_LAUNCH_MESSAGE = "Menu/Escape/RevertToLaunchWarningModalMessage";
    private const string REVERT_TO_VAB_TITLE = "Menu/Escape/RevertToVABWarningModalTitle";
    private const string REVERT_TO_VAB_MESSAGE = "Menu/Escape/RevertToVABWarningModalMessage";
    public ContextBindRoot bindRoot;
    private const LogFilter LOGTAG = (LogFilter) 2097152;
    private const string PREFIX = "[GlobalEscapeMenu] ";
    private IDataContextReadonly dataContext;
    private DataContext globalEscapeMenuContext;
    private PropertyExternal<bool> _canLeaveCurrentVessel;
    private Property<bool> _globalEscapeMenuVisible;
    private List<InputLockDefinition> _inputLocksToReEnable;
    private List<InputAction> _inputActionsToReEnable;
    private bool _reEnableCameraInput;
    private static readonly GameState[] _statesToStopTimeWarp;
    [SerializeField]
    private CanvasGroup _escapeMenuCanvasGroup;
    [SerializeField]
    private TutorialPauseMenu _tutorialPauseMenu;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LockInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableAction(InputAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnlockInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetEscMenusCanvasVisibility(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResumeGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResumeGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowNotSupportedInThisGameModeDialogBox(string featureName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowNotImplementedYetDialogBox(string featureName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleSettings(bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RevertToLaunchpadWarningModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RevertToLaunchpad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RevertToVABWarningModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RevertToVAB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RevertVehicleToVAB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVesselRecovery() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecoverVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OpenOABHistoricalSnapshot(
      OABHistoricalSnapshot oabHistoricalSnapshot,
      Action onLaunchCallback,
      Action onOABShowCompleteCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Colony() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void KSC() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MissionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TrainingCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VehicleAssemblyBuilding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Launchpad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Runway() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Settings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void QuitToMainMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void QuitGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExitToMainMenuWithoutSaving() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveAndExitToMainMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FireQuitToMainMenuMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void QuitGameWithoutSaving() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveAndExitGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QuitTutorial(bool reloadPriorState, Action onCompleteCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetCanLeaveActiveVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCanObserverLeaveActiveVesselValueChangedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckAndLeaveTrainingCenterAndMissionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTimeWarpState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GlobalEscapeMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static GlobalEscapeMenu() => throw null;
  }
}
