// Decompiled with JetBrains decompiler
// Type: LightTimer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
