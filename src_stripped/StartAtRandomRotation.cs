// Decompiled with JetBrains decompiler
// Type: StartAtRandomRotation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class StartAtRandomRotation : OABOrFlightEnablable
{
  [Space(10f)]
  [SerializeField]
  private bool xAxis;
  [SerializeField]
  private bool yAxis;
  [SerializeField]
  private bool zAxis;
  [SerializeField]
  private float xAngleRange;
  [SerializeField]
  private float yAngleRange;
  [SerializeField]
  private float zAngleRange;
  [SerializeField]
  private float xOffset;
  [SerializeField]
  private float yOffset;
  [SerializeField]
  private float zOffset;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetRandomAngle() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public StartAtRandomRotation() => throw null;
}
