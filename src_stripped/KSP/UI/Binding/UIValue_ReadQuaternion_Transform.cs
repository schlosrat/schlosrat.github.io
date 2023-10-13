// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadQuaternion_Transform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
