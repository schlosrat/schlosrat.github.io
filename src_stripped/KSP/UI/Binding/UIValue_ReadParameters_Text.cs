// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadParameters_Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_ReadParameters_Text : UIParameterStringBinder
  {
    [SerializeField]
    private TMP_Text text;
    [SerializeField]
    [TextArea(2, 10)]
    private string parameterString;

    protected override string ParameterString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private bool StringIsDirty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleStringRebuild() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadParameters_Text() => throw null;
  }
}
