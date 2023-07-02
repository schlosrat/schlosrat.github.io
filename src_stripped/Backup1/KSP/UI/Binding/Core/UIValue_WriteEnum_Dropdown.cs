// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_WriteEnum_Dropdown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public class UIValue_WriteEnum_Dropdown : UIValueEnumBinder
  {
    [SerializeField]
    private TMP_Dropdown dropdown;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMappedEnumValuesChanged(
      IReadOnlyList<string> newValues,
      bool shouldRedraw)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Dropdown_Changed(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteEnum_Dropdown() => throw null;
  }
}
