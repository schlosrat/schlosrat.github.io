// Decompiled with JetBrains decompiler
// Type: GaugeLEDRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
