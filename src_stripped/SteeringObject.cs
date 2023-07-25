﻿// Decompiled with JetBrains decompiler
// Type: SteeringObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class SteeringObject
{
  public Transform pivot;
  public Quaternion neutralAngle;
  public SteeringObject.ControlAxis controlAxis;
  public SteeringObject.AlignmentAxis alignmentAxis;
  public float wheelDriveInvert;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void FindAlignmentAxis(Transform referenceTransform, Transform partTransform) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SteeringObject() => throw null;

  public enum ControlAxis
  {
    Forward,
    Right,
    Up,
  }

  public enum AlignmentAxis
  {
    Forward,
    Up,
    Right,
    None,
  }
}
