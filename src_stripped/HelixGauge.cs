// Decompiled with JetBrains decompiler
// Type: HelixGauge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class HelixGauge : MonoBehaviour
{
  public Transform helixCW;
  public Transform helixCCW;
  public Transform clipPlane;
  public float ZatMinValue;
  public float ZatMaxValue;
  public float MinValue;
  public float MaxValue;
  public bool positiveValuesClockwise;
  public float currentValue;
  public float currentAngle;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateGauge() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public HelixGauge() => throw null;
}
