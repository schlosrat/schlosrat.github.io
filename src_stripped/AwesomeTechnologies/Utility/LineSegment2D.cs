// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.LineSegment2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  public struct LineSegment2D
  {
    public Vector2 Point0;
    public Vector2 Point1;
    public Vector2 Center;
    public Vector2 Direction;
    public readonly float Extent;
    public int DisableEdge;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineSegment2D(Vector2 point0, Vector2 point1) => throw null;
  }
}
