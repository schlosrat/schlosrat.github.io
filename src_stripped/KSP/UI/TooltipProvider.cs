// Decompiled with JetBrains decompiler
// Type: KSP.UI.TooltipProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class TooltipProvider : KerbalMonoBehaviour
  {
    private Canvas _tooltipCanvas;
    private ITooltipTarget _currentTarget;
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
    public T RequestTooltip<T>(T tooltip, bool checkActivateTooltipsSetting = true) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T RequestTooltip<T>(object id, T tooltip, bool checkActivateTooltipsSetting = true) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObjectPool<T> CreateNewPool<T>(object id, T tooltip) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseTooltip<T>(T tooltip) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseTooltip<T>(object id, T tooltip) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetAnchorPositionMouse() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetAnchorPositionObject(Transform targetObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TooltipProvider() => throw null;
  }
}
