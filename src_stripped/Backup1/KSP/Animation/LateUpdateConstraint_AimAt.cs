// Decompiled with JetBrains decompiler
// Type: KSP.Animation.LateUpdateConstraint_AimAt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
