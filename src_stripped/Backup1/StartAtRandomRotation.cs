﻿// Decompiled with JetBrains decompiler
// Type: StartAtRandomRotation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
