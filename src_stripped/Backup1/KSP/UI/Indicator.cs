// Decompiled with JetBrains decompiler
// Type: KSP.UI.Indicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [RequireComponent(typeof (CanvasGroup))]
  public class Indicator : KerbalMonoBehaviour
  {
    [SerializeField]
    protected IndicatorData indicatorData;
    protected RectTransform _thisRectTransform;
    protected CanvasGroup _canvasGroup;
    protected Action<Indicator> _onHideCallback;
    protected float closeTimeCached;

    public IndicatorData IndicatorData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Show(IndicatorData indicatorData, Action<Indicator> onHideCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void InitializePosition(Vector2 screenSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdatePosition(
      Vector3 worldPosition,
      RectTransform canvasRectTransform,
      Camera uiCamera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ViewportClip(Vector3 viewportPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TrackGameObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateValidTrackingObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PositionUsingOffsets(bool checkIfTrackingObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool IsVisibleFrom(RectTransform parentRectTransform, Camera UICamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void DismissAfterTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Indicator() => throw null;
  }
}
