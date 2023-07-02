// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadBool_ImageDouble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
