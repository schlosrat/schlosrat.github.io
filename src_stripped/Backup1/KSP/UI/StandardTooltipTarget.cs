// Decompiled with JetBrains decompiler
// Type: KSP.UI.StandardTooltipTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class StandardTooltipTarget : KerbalMonoBehaviour, ITooltipTarget
  {
    [SerializeField]
    private StandardTooltip _tooltipObject;
    private StandardTooltip _currentTooltip;
    [Tooltip("Rect transform to be used for tooltip position, instead of using current mouse position.")]
    [SerializeField]
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
