// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadLocalizedString_Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using I2.Loc;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_ReadLocalizedString_Text : UIValueBinder<string>
  {
    [SerializeField]
    private Localize Localizer;
    [SerializeField]
    private string ParamName;
    [SerializeField]
    private TMP_Text text;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadLocalizedString_Text() => throw null;
  }
}
