// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadMetaLocLabel_Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_ReadMetaLocLabel_Text : UIValueBinder<string>
  {
    [SerializeField]
    private TMP_Text text;
    [SerializeField]
    private string stringFormat;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdateMetadataFromContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadMetaLocLabel_Text() => throw null;
  }
}
