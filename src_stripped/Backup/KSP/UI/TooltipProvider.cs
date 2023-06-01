// Decompiled with JetBrains decompiler
// Type: KSP.UI.TooltipProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class TooltipProvider : KerbalMonoBehaviour
  {
    private Canvas _tooltipCanvas;
    private ITooltipTarget _currentTarget;
    private PointerEventData _pointerData;
    private List<RaycastResult> _uiRaycastResults;
    private RaycastHit[] _physicsRaycastResults;
    private Dictionary<object, object> _tooltipPools;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateHoverTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetNewTarget(ITooltipTarget newTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CheckHitUI(out ITooltipTarget foundTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CheckHitPhysics(out ITooltipTarget foundTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T RequestTooltip<T>(T tooltip) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T RequestTooltip<T>(object id, T tooltip) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseTooltip<T>(T tooltip) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseTooltip<T>(object id, T tooltip) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetAnchorPositionMouse() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetAnchorPositionObject(Vector3 objectPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TooltipProvider() => throw null;
  }
}
