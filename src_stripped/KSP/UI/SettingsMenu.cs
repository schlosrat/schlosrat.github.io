// Decompiled with JetBrains decompiler
// Type: KSP.UI.SettingsMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class SettingsMenu : KerbalMonoBehaviour
  {
    [SerializeField]
    private Button applyButton;
    [SerializeField]
    private Button revertButton;
    private const string SAVE_BEFORE_EXITING = "Menu/Escape/SaveBeforeExiting";
    private const string SAVE_BEFORE_EXITING_WARNING = "Menu/Escape/SaveBeforeExitingWarning";
    private const string APPLY = "Menu/Settings/Apply";
    private const string REVERT = "Menu/Settings/Revert";
    [Header("Sub Menus")]
    public InputSettingsMenu InputSettingsMenu;
    public GameplaySettingsMenu GameplaySettingsMenu;
    public GraphicsSettingsMenu GraphicsSettingsMenu;
    public AudioSettingsMenu AudioSettingsMenu;
    public MultiplayerSettingsMenu MultiplayerSettingsMenu;
    private SettingsSubMenu _activeMenu;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSinglePlayerMultiplayerModifications() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisibility(bool isVisible, bool tween) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleMenu(SettingsSubMenu menu) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InputSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GameplaySettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GraphicsSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AudioSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MultiplayerSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Apply() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyOnBack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RevertOnBack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Back() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseMenuSubOrSelf() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SettingsMenu() => throw null;
  }
}
