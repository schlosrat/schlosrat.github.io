// Decompiled with JetBrains decompiler
// Type: KSP.Game.Colonies.ColonyManagerDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game.Colonies
{
  public class ColonyManagerDialog : KerbalMonoBehaviour
  {
    [SerializeField]
    private RectTransform _activeFlightList;
    [SerializeField]
    private RectTransform _deliveryRouteList;
    [SerializeField]
    private ColonyManagerDialogEntry _entryPrefab;
    [SerializeField]
    private ButtonExtended _closeWindowButton;
    [SerializeField]
    private ButtonExtended _refreshWindowButton;
    private List<ColonyManagerDialogEntry> _activeFlightUIControls;
    private List<ColonyManagerDialogEntry> _deliveryRouteUIControls;
    private SubscriptionHandle _ColonyDataUpdatedHandle;
    private bool _isInitialized;
    private bool _isDirty;
    public bool IsLoading;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DismissDialog() => throw null;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnColonyDataUpdated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddFlightEntry(ActiveFlight flight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddRouteEntry(DeliveryRoute route) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearAllUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyManagerDialog() => throw null;
  }
}
