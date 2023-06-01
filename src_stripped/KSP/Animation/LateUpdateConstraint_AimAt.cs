// Decompiled with JetBrains decompiler
// Type: KSP.Animation.LateUpdateConstraint_AimAt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using EdyCommonTools;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Animation
{
  public class LateUpdateConstraint_AimAt : LateUpdateConstraint
  {
    [SerializeField]
    private MathUtility.Axis _facingAxis;
    [SerializeField]
    private Transform _transformToAimAt;
    [SerializeField]
    private Transform _transformUpNode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdateTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LateUpdateConstraint_AimAt() => throw null;
  }
}
