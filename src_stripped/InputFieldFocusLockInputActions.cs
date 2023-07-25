// Decompiled with JetBrains decompiler
// Type: InputFieldFocusLockInputActions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Input;
using KSP.Logging;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[RequireComponent(typeof (InputFieldExtended))]
public class InputFieldFocusLockInputActions : KerbalMonoBehaviour
{
  private const LogFilter LOG_TAG = (LogFilter) 2097152;
  [Header("Input Action Maps To Disable")]
  public bool DisableAllInputActionMaps;
  [Space]
  public bool DisableInputActionsGlobal;
  public bool DisableInputActionsOAB;
  public bool DisableInputActionsFlight;
  public bool DisableInputActionsMapView;
  private bool DisableInputAudio;
  [Space(order = 1)]
  [Header("Debugging", order = 2)]
  public bool verboseLogging;
  private InputFieldExtended _inputField;
  private InputManager _inputManager;
  private GlobalInputDefinition _globalDefinition;
  private FlightInputDefinition _flightDefinition;
  private OabInputDefinition _oabDefinition;
  private MapViewInputDefinition _mapViewDefinition;
  private AudioInputDefinition _audioDefinition;
  private readonly List<InputDefinition> _inputsToDisable;
  private readonly List<InputDefinition> _inputsToReEnable;
  private List<InputAction> _globalActionsToReDisable;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnFieldFocusChanged(bool isFocused) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetInputLocks(bool shouldLock) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void FillInputDefinitionsToDisable(IList<InputDefinition> toDisable, bool clear = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public InputFieldFocusLockInputActions() => throw null;
}
