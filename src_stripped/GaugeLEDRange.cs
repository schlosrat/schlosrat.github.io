﻿// Decompiled with JetBrains decompiler
// Type: GaugeLEDRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class GaugeLEDRange
{
  public float minValue;
  public float maxValue;
  public GaugeLEDRange.LedAction ledAction;
  public LED.colorIndices color;
  public float blinkInterval;
  public AudioClip soundClip;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GaugeLEDRange() => throw null;

  public enum LedAction
  {
    off,
    on,
    blink,
  }
}
