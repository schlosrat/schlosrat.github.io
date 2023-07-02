// Decompiled with JetBrains decompiler
// Type: KSP.UI.MapUISelectableEntryTooltipTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
