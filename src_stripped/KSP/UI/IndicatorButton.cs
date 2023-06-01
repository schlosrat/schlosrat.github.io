// Decompiled with JetBrains decompiler
// Type: KSP.UI.IndicatorButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace KSP.UI
{
  public class IndicatorButton : Indicator
  {
    [SerializeField]
    private ButtonExtended _button;
    [SerializeField]
    private float _dismissAfterTime;
    [Tooltip("If false, this object wont automatically display when entering screenspace - useful when display is controlled by a third party")]
    [SerializeField]
    private bool _displayWhenOnScreen;
    [SerializeField]
    private bool _dontDissmissAfterTime;
    [Tooltip("If true, this object will automatically hide when game state is changed")]
    [SerializeField]
    private bool _hideOnGameStateChanged;
    private float _displayStartTime;
    private string _indicatorId;
    private SubscriptionHandle _onGameStateChangedSubscriptionHandle;
    private SubscriptionHandle _onTrainingCenterEnteredSubscriptionHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddListener(UnityAction onClick) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleDisplay(bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIndicatorId(string id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Show(IndicatorData indicatorData, Action<Indicator> onHideCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideImmediately(MessageCenterMessage msg = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Display() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideAfterDelay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdatePosition(
      Vector3 worldPosition,
      RectTransform canvasRectTransform,
      Camera UICamera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IndicatorButton() => throw null;
  }
}
