// Decompiled with JetBrains decompiler
// Type: KSP.UI.StandardTooltipTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class StandardTooltipTarget : KerbalMonoBehaviour, ITooltipTarget
  {
    [SerializeField]
    private StandardTooltip _tooltipObject;
    protected StandardTooltip _currentTooltip;
    [SerializeField]
    [Tooltip("Rect transform to be used for tooltip position, instead of using current mouse position.")]
    private RectTransform _targetRectTransform;
    [SerializeField]
    private int _priority;

    public int Priority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnEnter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnExit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardTooltipTarget() => throw null;
  }
}
