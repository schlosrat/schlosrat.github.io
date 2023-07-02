// Decompiled with JetBrains decompiler
// Type: LED
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LED : MonoBehaviour
{
  public Texture2D[] ledColors;
  public LED.colorIndices currentColor;
  private bool blinking;
  private bool blinkState;
  private float blinkInterval;

  public LED.colorIndices color
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool isOn
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool isBlinking
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void setColor(LED.colorIndices color) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void setOn() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void setOn(bool on) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void setOff() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void blink(float interval) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator doBlink() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LED() => throw null;

  public enum colorIndices
  {
    off,
    red,
    yellow,
    green,
    blue,
    purple,
  }
}
