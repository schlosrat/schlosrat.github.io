// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.SplineFollowerChaser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public class SplineFollowerChaser : MonoBehaviour
  {
    public SplineFollower target;
    public float maxSpeed;
    public float minDistance;
    public float maxDistance;
    public float innerAngle;
    public float outerAngle;
    public float minSpeed;
    public bool ignoreVerticalDistance;
    public bool enableGizmos;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SplineFollowerChaser() => throw null;
  }
}
