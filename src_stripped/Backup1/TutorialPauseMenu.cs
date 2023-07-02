// Decompiled with JetBrains decompiler
// Type: TutorialPauseMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Game.Missions;
using KSP.UI.Binding;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialPauseMenu : KerbalMonoBehaviour
{
  public Action<bool> onTutorialPauseMenuCanvasActiveChanged;
  private const string EXIT_WITHOUT_SAVING = "Menu/Escape/ExitWithoutSaving";
  private const string SAVE_BEFORE_EXITING = "Menu/Escape/SaveBeforeExiting";
  private const string SAVE_BEFORE_EXITING_WARNING = "Menu/Escape/SaveBeforeExitingWarning";
  [SerializeField]
  private ContextBindRoot BindRoot;
  public CanvasGroup _canvasGroup;
  [SerializeField]
  private CanvasGroup _globalEscapeMenuCanvasGrp;
  private DataContext _tutorialPauseMenuContext;
  private KSP2MissionManager MissionManager;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitializeContextBinding() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void HideWindow() => throw null;

  public bool IsVisible
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetVisible(bool visible) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Resume() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Restart() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void TrainingCenter() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ReturnToGame() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OpenSettingsMenu() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void QuitToMainMenu() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void QuitTutorial(bool reloadPriorState, Action onCompleteCallback) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ExitToMainMenuWithoutSaving() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TutorialPauseMenu() => throw null;
}
