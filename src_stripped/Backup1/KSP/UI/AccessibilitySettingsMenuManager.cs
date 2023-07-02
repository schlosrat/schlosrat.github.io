// Decompiled with JetBrains decompiler
// Type: KSP.UI.AccessibilitySettingsMenuManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class AccessibilitySettingsMenuManager : SettingsSubMenu
  {
    private const string SUB_TITLE_TEXT_SIZE_PROPERTY_KEY = "SubTitleTextSize";
    private const string TOGGLE_QUICK_LOAD_PROPERTY_KEY = "ToggleQuickLoad";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private static SubTitleTextSizeMode _defaultSubTitleSize;
    private Property<SubTitleTextSizeMode> _subTitleTextSize;
    private Property<bool> _isQuickLoadToggleHold;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSubtitleSizeChanged(SubTitleTextSizeMode value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnQuickLoadToggleChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplySubTitleSize(string selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyToggleQuickLoad(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AccessibilitySettingsMenuManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AccessibilitySettingsMenuManager() => throw null;
  }
}
