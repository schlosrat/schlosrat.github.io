// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationUIProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Messages;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class NotificationUIProvider : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [Header("Passive Tier")]
    [SerializeField]
    private NotificationUIPassive _passiveUIPrefab;
    [SerializeField]
    private RectTransform _passiveUIParent;
    [SerializeField]
    private int _maxOnScreenPassiveNotifications;
    [Header("Alert Tier")]
    [SerializeField]
    private NotificationUIAlert _alertUIPrefab;
    [SerializeField]
    private RectTransform _alertUIParent;
    [SerializeField]
    private CanvasGroup _alertUICanvasGroup;
    [Header("Admin Tier")]
    [SerializeField]
    private NotificationUIAdmin _adminUIPrefab;
    [SerializeField]
    private RectTransform _adminUIParent;
    private bool _initialized;
    private SubscriptionHandle _dismissAllNotificationsHandle;
    private SubscriptionHandle _onStartGameShutdownHandle;
    private Property<bool> _hidden;
    private GameObjectPool<NotificationUIPassive> _passiveNotificationPool;
    private List<NotificationUIPassive> _passiveUI;
    private List<NotificationUIPassive> _passiveExpired;
    private GameObjectPool<NotificationUIAlert> _alertNotificationPool;
    private List<NotificationUIAlert> _alertUI;
    private List<NotificationUIAlert> _alertExpired;
    private GameObjectPool<NotificationUIAdmin> _adminNotificationPool;
    private List<NotificationUIAdmin> _adminUI;
    private List<NotificationUIAdmin> _adminExpired;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DismissAllNotificationsMessageHandler(
      MessageCenterMessage dismissAllNotificationsMsg)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PushPassiveNotification(NotificationData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PushAlertNotification(NotificationData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PushAdminNotification(NotificationData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DismissAllNotifications() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CleanExpiredAndRecycleToPool(
      NotificationUIPassive passiveNotification = null,
      NotificationUIAlert alertNotification = null,
      NotificationUIAdmin adminNotification = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideNotificationCanvas(bool hidden) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStartGameShutdown(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeNotificationGameObjectPools() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NotificationUIProvider() => throw null;
  }
}
