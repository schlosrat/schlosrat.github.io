// Decompiled with JetBrains decompiler
// Type: KSP.Animation.LateUpdateConstraint_Position
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Animation
{
  public class LateUpdateConstraint_Position : LateUpdateConstraint
  {
    [SerializeField]
    private Transform _transformToConstrainTo;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdateTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LateUpdateConstraint_Position() => throw null;
  }
}
