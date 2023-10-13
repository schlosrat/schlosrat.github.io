// Decompiled with JetBrains decompiler
// Type: TestInput
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

public class TestInput : 
  IInputActionCollection2,
  IInputActionCollection,
  IEnumerable<InputAction>,
  IEnumerable,
  IDisposable
{
  private readonly InputActionMap m_Default;
  private List<TestInput.IDefaultActions> m_DefaultActionsCallbackInterfaces;
  private readonly InputAction m_Default_Button;
  private readonly InputAction m_Default_Axis;
  private int m_DefaultSchemeIndex;

  public InputActionAsset asset
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TestInput() => throw null;

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

  public TestInput.DefaultActions Default
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public InputControlScheme DefaultScheme
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public struct DefaultActions
  {
    private TestInput m_Wrapper;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultActions(TestInput wrapper) => throw null;

    public InputAction Button
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public InputAction Axis
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
    public static implicit operator InputActionMap(TestInput.DefaultActions set) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCallbacks(TestInput.IDefaultActions instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterCallbacks(TestInput.IDefaultActions instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveCallbacks(TestInput.IDefaultActions instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCallbacks(TestInput.IDefaultActions instance) => throw null;
  }

  public interface IDefaultActions
  {
    void OnButton(InputAction.CallbackContext context);

    void OnAxis(InputAction.CallbackContext context);
  }
}
