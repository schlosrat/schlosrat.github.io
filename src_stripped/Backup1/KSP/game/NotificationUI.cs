// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.Messages;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  [RequireComponent(typeof (CanvasGroup))]
  public class NotificationUI : KerbalMonoBehaviour
  {
    [SerializeField]
    protected ContextBindRoot _bindRoot;
    [SerializeField]
    protected GameObject _iconHolder;
    [SerializeField]
    protected GameObject _content;
    [SerializeField]
    protected LayoutElement _managerLayoutElement;
    [SerializeField]
    protected LayoutElement _contentLayoutElement;
    protected Property<Sprite> _primaryIcon;
    protected DataContext _dataContext;
    [Header("Tunable Properties")]
    [SerializeField]
    protected float _notificationHeight;
    [SerializeField]
    protected Vector3 _offsetFromDefaultPosition;
    [SerializeField]
    [Tooltip("Set the DOTween Fade In Animation")]
    [Header("DoTween Animations")]
    protected DOTweenAnimation fadeInAnimation;
    [SerializeField]
    [Tooltip("Set the DOTween Fade Out Animation")]
    protected DOTweenAnimation fadeOutAnimation;
    protected NotificationUIProvider _notificationUIProvider;
    protected NotificationData _notificationData;
    protected CanvasGroup _canvasGroup;
    protected SubscriptionHandle _gamePauseToggledMessageHandle;
    protected const float safeGuardTimeToDismiss = 5f;
    protected float timeSinceDisplayed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize(
      NotificationData data,
      NotificationUIProvider notificationUIProvider)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleFadeInSequence() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleFadeOutSequence() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnGamePauseToggled(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void AutoClose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetupAndLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void DismissNotification() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NotificationUI() => throw null;
  }
}
