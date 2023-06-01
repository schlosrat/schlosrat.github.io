// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadString_SetMaxObjectSize
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
  [RequireComponent(typeof (LayoutElement))]
  public class UIValue_ReadString_SetMaxObjectSize : UIValueBinder<string>
  {
    [SerializeField]
    protected LayoutElement _layoutElement;
    [SerializeField]
    private int _maxOneLineTextSize;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Resize(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadString_SetMaxObjectSize() => throw null;
  }
}
