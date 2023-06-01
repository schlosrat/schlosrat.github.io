// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadQuaternion_Transform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadQuaternion_Transform : UIValueBinder<Quaternion>
  {
    [SerializeField]
    private Transform boundTransform;
    [FormerlySerializedAs("rotationOffset")]
    [SerializeField]
    private Vector3 postRotationOffsetEuler;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadQuaternion_Transform() => throw null;
  }
}
