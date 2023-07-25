// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_info_parttooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_info_parttooltip : UIWidget
  {
    [SerializeField]
    [Header("Title - Readable")]
    private UIValueBinder titleText;
    [Header("Info - Readable")]
    [SerializeField]
    private UIValueBinder infoText;

    public IUIValueBindable<string> TitleText
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueBindable<string> InfoText
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_info_parttooltip() => throw null;
  }
}
