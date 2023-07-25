// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadString_SetMaxObjectSize
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
