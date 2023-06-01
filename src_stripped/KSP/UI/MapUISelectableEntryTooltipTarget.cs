// Decompiled with JetBrains decompiler
// Type: KSP.UI.MapUISelectableEntryTooltipTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (RectTransform))]
  public class MapUISelectableEntryTooltipTarget : KerbalMonoBehaviour, ITooltipTarget
  {
    [SerializeField]
    private MapUISelectableEntryTooltip _tooltipPrefab;
    [SerializeField]
    private Vector2 _tooltipOffset;
    private MapUISelectableEntryTooltipData _tooltipData;
    private MapUISelectableEntryTooltip _currentTooltip;
    private RectTransform _targetRectTransform;
    private LayoutElement _layoutElement;

    public int Priority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 TooltipOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(string primaryLineKey, string secondaryLineKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnExit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapUISelectableEntryTooltipTarget() => throw null;
  }
}
