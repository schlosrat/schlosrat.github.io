﻿// Decompiled with JetBrains decompiler
// Type: ExtendedInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ExtendedInput : MonoBehaviour
{
  private static string CurrentInputString;
  private static string LastInputString;
  private float EmtpyFrames;
  private float FrameThreshold;
  private static KeyCode LastKeyDetected;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetKey(KeyCodeExtended key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetKeyDown(KeyCodeExtended key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetKeyUp(KeyCodeExtended key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool WasPressed(string key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool IsPressed(string key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool DetectKeyDown(List<KeyCode> keyValues, out KeyCodeExtended key) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ExtendedInput() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static ExtendedInput() => throw null;
}
