// Decompiled with JetBrains decompiler
// Type: TriggerEmissiveLerpFromAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
