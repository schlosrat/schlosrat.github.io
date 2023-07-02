// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.LineSegment3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  public struct LineSegment3D
  {
    public Vector3 Point0;
    public Vector3 Point1;
    public Vector3 Center;
    public Vector3 Direction;
    public float Extent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineSegment3D(Vector3 point0, Vector3 point1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalcDir() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float DistanceTo(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float SqrPoint3Segment3(ref Vector3 point, ref LineSegment3D segment) => throw null;
  }
}
