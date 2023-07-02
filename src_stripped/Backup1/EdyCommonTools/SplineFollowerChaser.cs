// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.SplineFollowerChaser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
