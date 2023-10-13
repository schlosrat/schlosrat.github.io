// Decompiled with JetBrains decompiler
// Type: KSP.UI.Basic2DTooltipTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [RequireComponent(typeof (RectTransform))]
  public class Basic2DTooltipTarget : KerbalMonoBehaviour, ITooltipTarget
  {
    [SerializeField]
    private Basic2DTooltip _tooltipPrefab;
    [SerializeField]
    private Vector2 _tooltipOffset;
    [Header("Tooltip data")]
    [SerializeField]
    protected BasicTextTooltipData _tooltipData;
    [SerializeField]
    [Space]
    [Tooltip("Check if the tooltip is not supposed to follow the mouse pointer")]
    private bool _isAnchoredToTarget;
    [SerializeField]
    [Header("Tweakable values if the tooltip is anchored to the target")]
    private bool _useTargetWidth;
    [SerializeField]
    private TooltipPivotEnum _tooltipPivot;
    private Basic2DTooltip _currentTooltip;
    private Vector2 _calculatedTooltipOffset;
    private RectTransform _targetRectTransform;
    private bool _isInitialized;
    private string _tooltipPrefabId;

    public int Priority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 TooltipOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnEnter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnExit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetTooltipPivot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Basic2DTooltipTarget() => throw null;
  }
}
