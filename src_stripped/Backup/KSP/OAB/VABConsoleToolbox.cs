// Decompiled with JetBrains decompiler
// Type: KSP.OAB.VABConsoleToolbox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Input;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class VABConsoleToolbox : KerbalMonoBehaviour
  {
    [Header("Initialize ui reference")]
    public GameObject ButtonLaunchAssembly;
    public VerticalLayoutGroup _backgroundVerticalGroup;
    private IObjectAssemblyPart _part;
    private IObjectAssemblyPart _partSelected;
    private CanvasGroup _canvasGroup;
    private RectTransform _rectTransform;
    private ObjectAssemblyBuilder _builder;
    private bool _isPreviousVisible;
    private Vector3 _previousCursorPosition;
    private GameInput.ConsoleToolboxActions _input;
    private bool _isActive;

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSelectedPart(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilder builder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Drag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Focus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMain() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Duplicate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Delete() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Undo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAssemblyAnchor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleSymmetryMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TogglePartSnapping() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideCallback(InputAction.CallbackContext ctx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator UpdateUI(Action finishedCallBack) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VABConsoleToolbox() => throw null;
  }
}
