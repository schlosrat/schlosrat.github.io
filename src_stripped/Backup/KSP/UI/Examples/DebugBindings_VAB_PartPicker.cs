﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Examples.DebugBindings_VAB_PartPicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.OAB;
using KSP.UI.Binding.Group;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Examples
{
  public class DebugBindings_VAB_PartPicker : DebugBindings_Root
  {
    [SerializeField]
    [Header("Faux Game Data")]
    private AssemblyBuilderPartCategory partCategory;
    [SerializeField]
    private DebugBindings_VAB_PartPicker.Mock_PartSortMode partSortMode;
    [SerializeField]
    private DebugBindings_VAB_PartPicker.Mock_PartViewMode partViewMode;
    [Space(5f)]
    [SerializeField]
    private string partSearchString;
    [SerializeField]
    [Space(5f)]
    private string tooltipPartName;
    [SerializeField]
    private string tooltipPartDescription;
    [SerializeField]
    private Texture tooltipPartIcon;
    [Space(15f)]
    [SerializeField]
    private UIGroup_PartPicker partPickerGroup;
    private PropertyExternal<string> partCategoryProp;
    private PropertyExternal<string> partSortModeProp;
    private PropertyExternal<string> partSortViewProp;
    private PropertyExternal<string> partSearchStringProp;
    private PropertyExternal<string> tooltipPartNameProp;
    private PropertyExternal<string> tooltipPartDescriptionProp;
    private PropertyExternal<Texture> tooltipPartIconProp;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnQueuedValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AutoChangeValueTick(float dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DebugBindings_VAB_PartPicker() => throw null;

    private enum Mock_PartSortMode
    {
      SIZE,
      FUEL,
      MASS,
      TYPE,
    }

    private enum Mock_PartViewMode
    {
      TILE,
      LIST,
    }
  }
}
