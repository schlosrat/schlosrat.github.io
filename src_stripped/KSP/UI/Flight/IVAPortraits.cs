// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.IVAPortraits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Modules;
using KSP.Sim.impl;
using KSP.UI.Binding.Widget;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.UI.Flight
{
  public class IVAPortraits : 
    UIFlightHUDInstrument,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler
  {
    private static IVAPortraits Instance;
    private const string IVA_SUBCONTEXT_KEY = "IVAPortraitsUI";
    private const string CAN_EXPAND_PROPERTY_KEY = "CanExpand";
    private const string CAN_NEXT_PROPERTY_KEY = "CanShowNext";
    private const string CAN_PREVIOUS_PROPERTY_KEY = "CanShowPrevious";
    private const string NEXT_SET_ACTION_KEY = "ShowNextSet";
    private const string PREVIOUS_SET_ACTION_KEY = "ShowPreviousSet";
    private const string IS_MOUSEOVER_PROPERTY_KEY = "IsMouseover";
    private const string PORTRAIT_RENDER_TEXTURE_NAME = "IVAPortrait";
    private const int MAX_PORTRAIT_COLLAPSED_COUNT = 3;
    private const int WAIT_FRAMES_AFTER_REBUILD = 1;
    [SerializeField]
    private float _portraitRenderCadenceInSeconds;
    [Header("UI Prefabs to Spawn in Location and Bind")]
    [SerializeField]
    [Space(10f)]
    private GameObject _ivaPortraitPrefab;
    [SerializeField]
    private GameObject _ivaPortraitContainer;
    [SerializeField]
    private ScrollbarExtended _positionIndicator;
    [SerializeField]
    private Material _skyboxMaterial;
    [SerializeField]
    private Texture2D _signalLostTexture;
    [SerializeField]
    private string _emptySlotText;
    [SerializeField]
    private RectTransform _portraitRect;
    private DataContext _uiData;
    private Property<bool> _canExpand;
    private Property<bool> _canShowNext;
    private Property<bool> _canShowPrevious;
    private Property<bool> _isMouseover;
    private List<IVAPortraits.PortraitMapping> _ivaPortraitMappings;
    private List<(RenderTexture texture, Camera camera)> _generatedRenderTextures;
    private bool _renderPortraits;
    private IVAPortraitEVAObstacleDetector _evaObstacleDetector;
    private List<List<(Camera Camera, int SeatIndex)>> _portraitPages;
    private List<(Camera Camera, int SeatIndex)> _currentPortraitPage;
    private int _totalPortraitPageCount;
    private int _currentPortraitPageNumber;
    private VesselDataProvider _vesselDataProvider;
    private SubscriptionHandle _handleGameStateChanged;
    private SubscriptionHandle _handleMapModeChanged;
    private float _timeUntilNextRender;
    private int _renderIndex;
    private Camera _lastCameraRendered;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapModeChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePortraitRenderTexture(IVAPortraits.PortraitMapping portraitMapping) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderOneFrame(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSignalLostImage(IVAPortraits.PortraitMapping portraitMapping) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEVAEnabled(IVAPortraits.PortraitMapping portraitMapping) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Camera> GetVisiblePortraitCameras() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPortraitRenderCadenceTime(float newCadenceInSeconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderNextPortrait() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableIVACamera(bool enable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearPortraitUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeRenderTextures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private RenderTexture GetAvailableRenderTexture(
      UIWidget_viewport_ivaportrait curWidget,
      Camera cameraToRender)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePortraitUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildPortraitSetsFromList(
      IReadOnlyList<(Camera Camera, int SeatIndex)> cameraList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangePageNumber(int pageNumber) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator WaitForUiRefresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnProbeReady(IVAPortraits.PortraitMapping portraitMapping) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBuilt3DKerbal(IVAPortraits.PortraitMapping portraitMapping) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BlankPortraitSlot(IVAPortraits.PortraitMapping portraitMapping) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCharacterCompletelyGenerated(string kerbalFullName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClickedButtonEVA(
      IVAPortraits.PortraitMapping portraitMapping,
      Module_CrewedInterior moduleCrewedInterior)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePortraitUIEventHandle(IReadOnlyList<(Camera, int)> cameraList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowNextSet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowPreviousSet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IVAPortraits() => throw null;

    [Serializable]
    private class PortraitMapping
    {
      public UIWidget_viewport_ivaportrait UiWidget;
      public BasicTextTooltipData TooltipData;
      public Kerbal3DModel Kerbal3DInstance;
      public PartBehavior VesselPartBehavior;
      public int seatIdx;
      public Camera RenderCam;
      public Skybox RenderSkybox;
      public bool IsEVAEnabled;
      public bool IsValid;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetEVAInteractable(bool isEVAEnabled, bool force) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetTooltipLocKey(string tooltipLocKey) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PortraitMapping() => throw null;
    }
  }
}
