// Decompiled with JetBrains decompiler
// Type: KSP.Input.Iteration.InputManagerTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Input.Iteration
{
  public class InputManagerTester : MonoBehaviour
  {
    private InputManager _manager;
    private TestInput _input;
    private DefaultInputDefinition _definition;
    private bool _lockActive;
    public Button buttonPrefab;
    public RectTransform actionButtonContainer;
    public RectTransform lockButtonContainer;
    public Text actionLog;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerButtonAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerAxisAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnButtonInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAxisInput(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleInputLock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputManagerTester() => throw null;
  }
}
