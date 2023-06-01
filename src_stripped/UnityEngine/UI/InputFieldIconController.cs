// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.InputFieldIconController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;

namespace UnityEngine.UI
{
  [RequireComponent(typeof (InputFieldExtended))]
  public class InputFieldIconController : KerbalMonoBehaviour
  {
    [SerializeField]
    private CanvasGroup _editIconCanvasGroup;
    [Space]
    [SerializeField]
    private CanvasGroup _clearButtonCanvasGroup;
    [SerializeField]
    [Space]
    private ButtonExtended _clearButton;
    [Space]
    [SerializeField]
    private CanvasGroup _characterNumberCanvasGroup;
    [SerializeField]
    private TextMeshProUGUI _characterNumberText;
    [Header("Custom options")]
    [SerializeField]
    private bool _useCustomClearButtonAction;
    [SerializeField]
    private bool _showEditIconOnNormalState;
    private InputFieldExtended _inputField;
    private SelectionState _mostRecentState;
    private bool _isCursorOnButton;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleStateChange(SelectionState state, bool val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValueChangedEvent(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeselect(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearInteracted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleButtonChange(SelectionState state, bool val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetElementImageStates(bool buttonState, bool iconState, bool characterNbr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputFieldIconController() => throw null;
  }
}
