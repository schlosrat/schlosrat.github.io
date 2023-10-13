// Decompiled with JetBrains decompiler
// Type: SteeringObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
