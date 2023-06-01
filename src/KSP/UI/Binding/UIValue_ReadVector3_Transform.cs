// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadVector3_Transform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadVector3_Transform : UIValueBinder<Vector3>
  {
    [SerializeField]
    private Transform boundTransform;
    [SerializeField]
    private UIValue_ReadVector3_Transform.TransformGroup destinationGroup;
    [Tooltip("TRUE = local space  FALSE = world space")]
    [SerializeField]
    private bool applyAsLocalCoordinates;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadVector3_Transform() => throw null;

    private enum TransformGroup
    {
      POSITION,
      ROTATION,
      SCALE,
    }
  }
}
