// Decompiled with JetBrains decompiler
// Type: GaugeLEDRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
