// Decompiled with JetBrains decompiler
// Type: KSP.Input.InputRebindingController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI;
using KSP.UI.Binding;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KSP.Input
{
  public class InputRebindingController : SettingsSubMenu
  {
    private const string MAP_HEADER_KEY = "MapHeader";
    private const string BINDING_LABEL_KEY = "ActionName";
    private const string BINDING_DISPLAY_KEY = "BindingInput";
    private const string REBIND_PROMPT_VISIBLE_KEY = "RebindVisible";
    private const string REBIND_PROMPT_KEY = "RebindPrompt";
    private const string REBIND_ACTION_KEY = "RebindInput";
    private const string SETTINGS_LOC_PATH = "Menu/Settings";
    private const string PROMPT_OVERWRITE_TITLE_LOC_KEY = "Menu/Settings/The following is already assigned";
    private const string PROMPT_OVERWRITE_DESC_LOC_KEY = "Menu/Settings/Overwrite assignment description";
    private const string PROMPT_CANCEL_LOC_KEY = "Menu/Settings/Cancel";
    private const string PROMPT_PROCEED_LOC_KEY = "Menu/Settings/Proceed";
    public const string SettingsFilename = "InputBindings";
    public const string CONTROL_SCHEME_NAME_HIDE = "Hide";
    [SerializeField]
    private InputActionAsset _targetAsset;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private RectTransform _mapUIContainer;
    [SerializeField]
    private ContextBindRoot _inputMapUIPrefab;
    [SerializeField]
    private ContextBindRoot _inputActionUIPrefab;
    [SerializeField]
    private ContextBindRoot _inputBindingUIPrefab;
    [SerializeField]
    private InputBinding.DisplayStringOptions _displayStringOptions;
    [Tooltip("Rebinding will only display and handle the inputs with this selected control scheme")]
    [SerializeField]
    private string _targetControlScheme;
    private InputActionRebindingExtensions.RebindingOperation _currentRebindOperation;
    private bool _isInitialized;
    private bool _isActionEnabledOnStartRebinding;
    private Property<string> _rebindPromptProp;
    private Property<bool> _rebindPromptVisibleProp;
    private Dictionary<Guid, ContextBindRoot> _mapUIElements;
    private Dictionary<Guid, ContextBindRoot> _actionUIElements;
    private Dictionary<Guid, ContextBindRoot> _bindingUIElements;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadBindingsFromFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveBindingsToFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteBindingOverridesFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateUIElements() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasBindingsToDisplay(InputAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasActionsToDisplay(InputActionMap map) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateInputMapUI(InputActionMap map) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateInputActionUI(InputActionMap inputMap, InputAction inputAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateInputBindingUI(InputAction inputAction, InputBinding inputBinding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetBindingIndex(
      InputAction inputAction,
      InputBinding inputBinding,
      out int index)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SelectForRebinding(InputAction inputAction, InputBinding inputBinding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformInteractiveRebind(
      InputAction inputAction,
      int bindingIndex,
      bool compositeRebind = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EndRebind(InputAction inputAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnRebindCancel(InputAction inputAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnRebindComplete(InputAction inputAction, int bindingIndex, bool compositeRebind) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetDisplayStringForBinding(InputAction inputAction, InputBinding inputBinding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowOverwritePrompt(
      string bindingID,
      string keybindToOverwrite,
      Action onConfirm,
      Action onCancel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputRebindingController() => throw null;
  }
}
