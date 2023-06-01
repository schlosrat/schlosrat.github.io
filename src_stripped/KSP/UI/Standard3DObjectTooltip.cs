// Decompiled with JetBrains decompiler
// Type: KSP.UI.Standard3DObjectTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class Standard3DObjectTooltip : KerbalMonoBehaviour
  {
    protected const float TRACKING_SMOOTHING = 0.5f;
    [SerializeField]
    protected Vector2 _positionOffset;
    protected RectTransform _rectTransform;
    protected Transform _target;
    protected Camera _currentCamera;
    protected Canvas _tooltipCanvas;
    protected bool _isActive;
    private Vector2 _newOffsetPostion;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Configure(Transform target, Camera currentCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Show(Camera currentCamera = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual Vector2 Follow3DObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Standard3DObjectTooltip() => throw null;
  }
}
