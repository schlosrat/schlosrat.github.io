// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_ImageDouble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_ReadBool_ImageDouble : UIValueBinder<bool>
  {
    [Header("On State Image")]
    [SerializeField]
    private Image onImage;
    [SerializeField]
    private Image offImage;
    [SerializeField]
    [Space]
    private float animationDuration;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadBool_ImageDouble() => throw null;
  }
}
