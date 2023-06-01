// Decompiled with JetBrains decompiler
// Type: KSP.UI.ResearchDevelopmentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Research;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI
{
  public class ResearchDevelopmentController : KerbalMonoBehaviour
  {
    public const string RESEARCH_AND_DEVELOPMENT_PREFAB = "ResearchAndDevelopment.prefab";
    private const string RD_CENTER_PREFIX = "Menu/RDCenter/";
    private const string PROGRESSION_KEY = "Progression";
    private const string NEW_TOOLS_KEY = "New Tools";
    private const string QUALITY_OF_LIFE_KEY = "Quality Of Life";
    private const string REQUIRES_KEY = "Requires";
    private const string REQUIRES_ANY_KEY = "Requires Any";
    public ContextBindRoot BindRoot;
    public DataContext DataContext;
    public RDZoomPanel ZoomPanel;
    [SerializeField]
    private CanvasGroup _infoSideBarCanvasGrp;
    [Header("Sidebar elements")]
    [SerializeField]
    private ResearchButton _researchButton;
    [SerializeField]
    private ResearchDevelopmentTechnologyMiniature _headerMinature;
    [SerializeField]
    private TMP_Text _requireText;
    [SerializeField]
    private GameObject _prerequisitesGrid;
    [SerializeField]
    [Space]
    private ResearchDevelopmentTechnologyMiniature _prerequisitePrefab;
    private Property<string> _sidebarName;
    private Property<string> _sidebarType;
    private Property<string> _sidebarDescription;
    private Property<string> _sidebarCost;
    private List<ResearchDevelopmentTechnologyMiniature> _prerequisitesList;
    private List<DOTweenAnimation> _tweenAnimations;
    private ResearchDevelopmentTechTreeController _techTree;
    private TechnologyNode _lastSelectedNode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseSidebar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStateChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSideBar(bool isActive, TechnologyNode techNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePrerequisitesList(TechnologyNode techNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResearchTechnology() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResearchDevelopmentController() => throw null;
  }
}
