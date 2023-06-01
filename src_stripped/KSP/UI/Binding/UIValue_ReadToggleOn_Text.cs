// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadToggleOn_Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_ReadToggleOn_Text : UIValueBinder<bool>
  {
    [SerializeField]
    private ToggleExtended toggle;
    [SerializeField]
    private TMP_Text text;
    [SerializeField]
    private string stringFormat;
    [SerializeField]
    private string toggleIsOnText;
    [SerializeField]
    private string toggleIsOffText;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleToggleChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleToggleUpdate(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LocalizeToggleText(string toggleText) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadToggleOn_Text() => throw null;
  }
}
