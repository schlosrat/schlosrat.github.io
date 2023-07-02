// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.Navigator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Input;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace KSP.Navigation
{
  [DisallowMultipleComponent]
  [AddComponentMenu("UI Navigation/Navigator")]
  public class Navigator : KerbalMonoBehaviour, INavigator
  {
    public const float DEFAULT_HOLDING_POINT = 0.3f;
    public const float DEFAULT_INVOKE_INTERVAL = 0.1f;
    public const float DEFAULT_DEADZONE = 0.1f;
    public const float DEFAULT_MAX_CLICK_DURATION = 1f;
    public static List<INavigationLayout> Layouts;
    public float HoldingPoint;
    public float InvokeInterval;
    public float DeadZone;
    public float MaxClickDuration;
    private Stack<INavigatable> _layoutStack;
    private GameInput.Navigation_Move_LeftStickActions _inputMoveLeftStick;
    private bool _isInputMoveLeftStickOnUse;
    private GameInput.Navigation_Move_DPadActions _inputMoveDPad;
    private bool _isInputMoveDPadOnUse;
    private GameInput.Navigation_SubmitActions _inputSubmit;
    private bool _isInputSubmitOnUse;
    private GameInput.Navigation_QuitActions _inputQuit;
    private bool _isInputQuitOnUse;
    private GameInput.Navigation_ScrollActions _inputScroll;
    private bool _isInputScrollOnUse;

    public static INavigator Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static INavigationLayout GetLayout(string tag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static INavigationLayout GetLayout(Transform key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static HierachyGroup GetRootGroup(Transform key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static HierachyGroup GetGroup(Transform key) => throw null;

    public INavigatable CurrentLayout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private EventSystem eventSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private GameObject currentSelectedGameObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Select(Selectable element) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableInput(Navigator.InputType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableInput(Navigator.InputType type, bool forced = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    bool INavigator.Contains(INavigatable layout) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INavigator.LoadLayout(INavigatable layout) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INavigator.UnloadLayout(INavigatable layout) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void INavigator.UnloadAllLayout() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator HoldingRoutine<T>(
      InputAction inputAction,
      Action action,
      float waitTime,
      float invokeInterval)
      where T : IEventSystemHandler
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator SelectRoutine(
      InputAction inputAction,
      MoveDirection dir,
      float waitTime,
      float invokeInterval)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveUp(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveDown(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveLeft(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveRight(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Submit(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Quit(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HoldSubmit(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseSubmit(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Navigator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Navigator() => throw null;

    public enum InputType
    {
      MoveLeftStick,
      MoveDPad,
      Submit,
      Quit,
      Scroll,
      Previous,
    }
  }
}
