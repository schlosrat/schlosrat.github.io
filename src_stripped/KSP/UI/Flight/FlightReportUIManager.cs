// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.FlightReportUIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Flight
{
  public class FlightReportUIManager : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot flightReportBindRoot;
    [SerializeField]
    private CanvasGroup _canvasGroup;
    [SerializeField]
    private TextMeshProUGUI _flightStatusTextMesh;
    [SerializeField]
    private Color _defaultStatusColor;
    [SerializeField]
    private Color _successStatusColor;
    [SerializeField]
    private Color _failureStatusColor;
    [Header("Default window position")]
    [SerializeField]
    private float _defaultXWindowOffset;
    [SerializeField]
    private float _defaultYWindowOffset;
    [Header("Research Section")]
    [SerializeField]
    private FlightReportResearchItem _researchItemPrefab;
    [SerializeField]
    private RectTransform _researchParentTransform;
    [SerializeField]
    private Sprite _debugResearchItemIcon;
    [Header("Log Section")]
    [SerializeField]
    private FlightReportLogItem _logItemPrefab;
    [SerializeField]
    private RectTransform _logParentTransform;
    [Header("Crew Section")]
    [SerializeField]
    private FlightReportCrewItem _crewItemPrefab;
    [SerializeField]
    private RectTransform _crewParentTransform;
    [Tooltip("Time in seconds to wait for the next records' update.")]
    [SerializeField]
    [Header("Records Section")]
    private double _recordsUpdateRate;
    [Header("Success and Failure Messages Section")]
    [Tooltip("List of localization terms for messages that are picked at random to display in the flight report if we are successful or not.")]
    [SerializeField]
    private string[] _successMessageLocTerms;
    [SerializeField]
    private string[] _failureMessageLocTerms;
    [Header("Tutorials Section")]
    [Tooltip("List of localization terms for messages that are picked at random to display in Tutorials Section.")]
    [SerializeField]
    private string[] _tutorialMessageLocTerms;
    private DataContext _uiData;
    private Property<string> _flightStatusText;
    private Property<bool> _shouldDisplayResearchSection;
    private Property<bool> _enableReturnToVABButton;
    private Property<bool> _enableReturnToLaunchButton;
    private Property<bool> _enableTrackingStationButton;
    private Property<bool> _enableKSCButton;
    private Property<double> _missionElpasedTime;
    private Property<double> _altitudeRecord;
    private Property<double> _speedOverLandRecord;
    private Property<double> _speedOverallRecord;
    private Property<double> _groundDistanceRecord;
    private Property<double> _totalDistanceRecord;
    private Property<double> _gForceRecord;
    private Property<string> _tutorialMessageText;
    private const string FLIGHT_STATUS_IN_FLIGHT = "Flight/FlightReport/InFlightStatus";
    private const string FLIGHT_STATUS_FAILURE = "Flight/FlightReport/FailureStatus";
    private const string FLIGHT_STATUS_SUCCESS = "Flight/FlightReport/SuccessStatus";
    private IGGuid _activeVesselGuid;
    private bool _isInitialized;
    private bool _isBeingRecovered;
    private bool _isVesselDestroyed;
    private double _timeSinceLastUpdate;
    private RectTransform _windowRectTransform;
    private GameObjectPool<FlightReportResearchItem> _researchItemPool;
    private GameObjectPool<FlightReportLogItem> _logItemPool;
    private GameObjectPool<FlightReportCrewItem> _crewItemPool;
    private List<FlightReportResearchItem> _researchItems;
    private List<FlightReportLogItem> _logItems;
    private List<FlightReportCrewItem> _crewItems;
    public bool IsActive;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BindContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetCrewSection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanShowFlightReport(GameState currState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFlightHudCanvasActiveChanged(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLogData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateRecordsData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselRecovered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEventAdded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdateCrewItems(IReadOnlyList<(Camera, int)> _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddNewLogEntry(TravelObjectEvent newEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddNewCrewEntry(string crewName, Sprite crewIcon) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReturnToVAB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReturnToLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OpenTrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OpenTrainingCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TransitionToKSC() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightReportUIManager() => throw null;
  }
}
