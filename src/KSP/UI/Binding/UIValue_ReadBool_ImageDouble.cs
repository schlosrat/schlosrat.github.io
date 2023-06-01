// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_ImageDouble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_ReadBool_ImageDouble : UIValueBinder<bool>
  {
    [SerializeField]
    [Header("On State Image")]
    private Image onImage;
    [SerializeField]
    private Image offImage;
    [Space]
    [SerializeField]
    private float animationDuration;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadBool_ImageDouble() => throw null;
  }
}
