// Decompiled with JetBrains decompiler
// Type: LightTimer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
