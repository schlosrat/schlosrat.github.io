// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_info_parttooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_info_parttooltip : UIWidget
  {
    [Header("Title - Readable")]
    [SerializeField]
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
