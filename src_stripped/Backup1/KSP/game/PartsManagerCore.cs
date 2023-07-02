// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartsManagerCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Messages;
using KSP.UI.Binding;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.Game
{
  [RequireComponent(typeof (RectTransform))]
  [RequireComponent(typeof (CanvasGroup))]
  public class PartsManagerCore : 
    KerbalMonoBehaviour,
    ILateUpdate,
    IBeginDragHandler,
    IEventSystemHandler,
    IDragHandler,
    IInitializePotentialDragHandler
  {
    public const int PAM_MODULE_SORTINDEX_MULTIPLIER = 1000000;
    public const int PAM_MODULEDATA_SORTINDEX_MULTIPLIER = 1000;
    public const int PAM_DEFAULT_MODULE_SORT_INDEX = 998;
    public const int PAM_DEFAULT_MODULEDATA_SORT_INDEX = 998;
    public const int PAM_DEFAULT_FIELD_SORT_INDEX = 998;
    public const int PAM_MODULE_HEADER_SORT_INDEX = 0;
    public const int PAM_MODULE_FOOTER_SORT_INDEX = 999;
    [Header("Self")]
    [SerializeField]
    private RectTransform _rectTransform;
    [SerializeField]
    private CanvasGroup _canvasGroup;
    [SerializeField]
    [Header("Default window positions")]
    private float _defaultXWindowOffsetFlight;
    [SerializeField]
    private float _defaultYWindowOffsetFlight;
    [SerializeField]
    private float _defaultXWindowOffsetVab;
    [SerializeField]
    private float _defaultYWindowOffsetVab;
    [Header("Subsections")]
    [SerializeField]
    private PartsManagerPartsList _partsList;
    private RectTransform _rectTransformParent;
    private Vector2 _dragStartOffset;
    private bool _isInitialized;
    private SubscriptionHandle _oabNewAssemblyHandle;
    [SerializeField]
    private TextMeshProUGUI _vesselNameLabel;
    [SerializeField]
    private LayoutElement _headerLayoutElement;
    [SerializeField]
    private float _headerHeightMin;
    [SerializeField]
    private float _headerHeightWithVessel;
    private PartsManagerCore.ManagerSortData _managerSortData;
    [SerializeField]
    [Header("Binding")]
    private ContextBindRoot partsManagerBindRoot;
    private DataContext uiData;
    private bool _isInOAB;

    public PartsManagerPartsList PartsList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsInOAB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBeginDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnInitializePotentialDrag(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Refresh(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetVesselName(string vesselName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABLoaded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABUnloaded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetManagerSortIndexData(PartsManagerCore.ManagerSortData sortData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetModuleSortIndex(System.Type partComponentModuleType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetModuleDataSortIndex(System.Type partComponentModuleType, System.Type moduleDataType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetModuleShowHeader(System.Type partComponentModuleType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetModuleShowFooter(System.Type partComponentModuleType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartsManagerCore() => throw null;

    public class ManagerSortData
    {
      public Dictionary<string, int> ModuleSortIndex;
      public Dictionary<string, Dictionary<string, int>> ModuleDataSortIndex;
      public Dictionary<string, PartsManagerCore.ManagerModuleVisuals> ModuleVisuals;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ManagerSortData() => throw null;
    }

    public class ManagerModuleVisuals
    {
      public bool ShowHeader;
      public bool ShowFooter;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ManagerModuleVisuals() => throw null;
    }

    [Serializable]
    public class SerializedPartModuleDisplayOrder
    {
      public string PartComponentModuleName;
      public int sortIndex;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SerializedPartModuleDisplayOrder() => throw null;
    }

    [Serializable]
    public class SerializedPartModuleDisplayVisuals
    {
      public string PartComponentModuleName;
      public string ModuleDisplayName;
      public bool ShowHeader;
      public bool ShowFooter;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SerializedPartModuleDisplayVisuals() => throw null;
    }
  }
}
