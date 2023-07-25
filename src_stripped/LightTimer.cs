// Decompiled with JetBrains decompiler
// Type: LightTimer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LightTimer : MonoBehaviour
{
  public Light[] LightsToTrigger;
  [Tooltip("Leave negative to ignore. Lights will turn on after X seconds.")]
  public float TurnOnInSeconds;
  [Tooltip("Leave negative to ignore. Lights will turn off after X seconds.")]
  public float TurnOffInSeconds;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator DelayToggleLight(float delayTime, bool turnOn) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LightTimer() => throw null;
}
