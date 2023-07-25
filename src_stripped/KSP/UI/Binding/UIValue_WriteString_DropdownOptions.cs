// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteString_DropdownOptions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_WriteString_DropdownOptions : UIValueBinder<string>
  {
    [SerializeField]
    protected string dropdownDataKey;
    private DropdownItemList _itemDataCache;
    [SerializeField]
    private TMP_Dropdown dropdown;

    public string DropdownDataKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool HaveDropdownDataKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDropdownDataReady
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BindValue(IProperty valueProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Dropdown_Changed(int option) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDropdownOptions(DropdownItemList itemData, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDropdownOptionsChanged(DropdownItemList newItems, bool shouldRedraw) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteString_DropdownOptions() => throw null;
  }
}
