// Decompiled with JetBrains decompiler
// Type: ControllerBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
