// Decompiled with JetBrains decompiler
// Type: KSP.UI.StandardTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class StandardTooltip : KerbalMonoBehaviour
  {
    public bool IsFrozen;
    [SerializeField]
    protected Vector2 _positionOffset;
    protected RectTransform _rectTransform;
    protected bool _isActive;
    protected const float TRACKING_SMOOTHING = 0.5f;
    private Vector2 newOffsetPostion;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Show() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Show(RectTransform targetRect = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardTooltip() => throw null;
  }
}
