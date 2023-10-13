// Decompiled with JetBrains decompiler
// Type: LED
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
