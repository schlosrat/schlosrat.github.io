// Decompiled with JetBrains decompiler
// Type: TriggerEmissiveLerpFromAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class TriggerEmissiveLerpFromAnimation : MonoBehaviour
{
  public float TimeToTurnOn;
  [GradientUsage(true)]
  public Gradient OnGradient;
  public float TimeToTurnOff;
  [GradientUsage(true)]
  public Gradient OffGradient;
  public string EmissionColorParamName;
  public Renderer[] TargetRenderers;
  [SerializeField]
  private bool _turnOn;
  private bool _lerping;
  private float _lerpTimer;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetEmissive(Color newColor) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void TurnOn() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void TurnOff() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TriggerEmissiveLerpFromAnimation() => throw null;
}
