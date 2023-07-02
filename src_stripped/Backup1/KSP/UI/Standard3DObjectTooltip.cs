// Decompiled with JetBrains decompiler
// Type: KSP.UI.Standard3DObjectTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
