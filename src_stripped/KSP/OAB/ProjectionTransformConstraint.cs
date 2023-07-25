// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProjectionTransformConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ProjectionTransformConstraint : MonoBehaviour
  {
    [SerializeField]
    private Transform source01;
    [SerializeField]
    private Transform source02;
    [SerializeField]
    private ProjectionTransformConstraint.ReferenceVector refVector;
    [SerializeField]
    private bool flip;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateConstraint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 OrthogonalNormalVector(Vector3 A, Vector3 B, Vector3 up) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectionTransformConstraint() => throw null;

    private enum ReferenceVector
    {
      right,
      up,
      forward,
    }
  }
}
