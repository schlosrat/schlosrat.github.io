// Decompiled with JetBrains decompiler
// Type: ControllerBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

[Obsolete("Use GameInput instead of ControllerBinding")]
public class ControllerBinding : InputBinding_obsolete
{
  public KeyBinding keyBinding;
  public AxisBinding axisBinding;
  public ConsoleBinding consoleBinding;
  public float deadzone;
  private const float defaultHoldCheckTime = 0.85f;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private ControllerBinding() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ControllerBinding(
    KeyBinding _keyBinding,
    AxisBinding _axisBinding,
    ConsoleBinding _consoleBinding)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float GetAxis() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKey(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKeyDown(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKeyUp(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetDoubleTapDown(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetHold(float holdTime = 0.85f, bool ignoreInputLock = false) => throw null;
}
