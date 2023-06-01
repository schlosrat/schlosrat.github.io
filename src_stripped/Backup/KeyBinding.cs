// Decompiled with JetBrains decompiler
// Type: KeyBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Obsolete("requires some porting", false)]
public class KeyBinding : InputBinding_obsolete, ICloneable
{
  public KeyCodeExtended primary;
  public KeyCodeExtended secondary;
  public InputBindingModes switchStateSecondary;
  private const float doubleTapInterval = 0.2f;
  private int lastKeyDownFrameCount;
  private float lastKeyDownTime;
  private bool doubleDown;
  private int lastKeyUpFrameCount;
  private float lastKeyUpTime;
  private bool doubleUp;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KeyBinding() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KeyBinding(ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KeyBinding(KeyCode main) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KeyBinding(KeyCode main, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KeyBinding(KeyCode main, InputBindingModes useSwitch) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KeyBinding(KeyCode main, InputBindingModes useSwitch, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KeyBinding(KeyCode main, KeyCode alt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KeyBinding(KeyCode main, KeyCode alt, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KeyBinding(
    KeyCode main,
    KeyCode alt,
    InputBindingModes useSwitch,
    InputBindingModes useSwitchSecondary)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKey(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKeyDown(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKeyUp(bool ignoreInputLock = false) => throw null;

  public string name
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override bool IsNeutral() => throw null;
}
