﻿// Decompiled with JetBrains decompiler
// Type: ConsoleBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

public class ConsoleBinding : InputBinding_obsolete
{
  private ConsoleButtons mKey;
  private IPlatformController controller;
  private float holdStartTime;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ConsoleBinding() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ConsoleBinding(ConsoleButtons key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ConsoleBinding(ConsoleButtons key, ControlTypes lockMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKey(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKeyUp(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetKeyDown(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float GetAxis() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetDoubleTapDown(bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool GetHold(float holdtime, bool ignoreInputLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateConsoleController() => throw null;
}
