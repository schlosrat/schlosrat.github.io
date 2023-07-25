// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.UIFlightHud
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.UI.Binding;
using KSP.UserInterface;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  [PrefabName("FlightHudRoot.prefab")]
  public class UIFlightHud : UIModule
  {
    public bool UseOldFlightHud;
    public Action<bool> onFlightHudCanvasActiveChanged;
    [Space]
    [SerializeField]
    private ContextBindRoot stageMarkerPrefab;
    [Space]
    [SerializeField]
    private ContextBindRoot _context;
    [Space]
    [SerializeField]
    private CanvasGroup _canvasGroup;
    private DataContext _dataContext;
    private Dictionary<string, UIFlightHUDInstrument> _instruments;
    public Property<GameState> _gameState;
    private MeshRenderer[] _childMeshes;
    private const string GAME_STATE_PROPERTY_KEY = "GameState";
    private const string TRACKING_STATION_PROPERTY_KEY = "ToggleTrackingStation";
    private const string STAGEMARKER_PREFAB_KEY = "stageMarkerPrefab";
    private const string INSTRUMENTS_LABEL = "ui_hud_instrument";
    private const string INSTRUMENTS_OLD_LABEL = "ui_hud_instrument_old";

    public DataContext Context
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleFlightHUD() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightHudCanvasActiveChanged(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleTrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableVesselInstruments() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableColonyInstruments() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselCreated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnColonyFounded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetColonyInstrumentDisplay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetVesselInstrumentDisplay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadAllInstruments() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddInstrument(string id, GameObject instrument) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveInstrument(string id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIFlightHud() => throw null;
  }
}
