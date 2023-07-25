// Decompiled with JetBrains decompiler
// Type: KSP.Input.Iteration.InputManagerTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
