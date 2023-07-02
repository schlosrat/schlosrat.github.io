// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadParameters_Text
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
  public class UIValue_ReadParameters_Text : UIParameterStringBinder
  {
    [SerializeField]
    private TMP_Text text;
    [TextArea(2, 10)]
    [SerializeField]
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
