// Decompiled with JetBrains decompiler
// Type: KSP.Game.GlobalHeaderManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.Game.Missions;
using KSP.Map;
using KSP.Messages;
using KSP.UI;
using KSP.UI.Binding;
using KSP.UserInterface;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  [PrefabName("GlobalHeader.prefab")]
  public class GlobalHeaderManager : UIModule
  {
    public GameObject ContextualMenuContainer;
    public const string HEADER_PREFAB = "GlobalHeader.prefab";
    public const string CANVAS_SORTING_LAYER = "MasterUI";
    public ContextBindRoot PanelBindRoot;
    [SerializeField]
    private GHTutorialView _tutorialMenu;
    private DataContext _globalHeaderContext;
    private Dictionary<GameState, IGHContextualMenu> _contextualMenus;
    private IGHContextualMenu _currentMenu;
    private DOTweenAnimation[] _tweenAnimations;
    private const string SHOW_ANIMATION_CONST = "showAnimation";
    private const string HIDE_ANIMATION_CONST = "hideAnimation";
    private bool _backgroundState;
    private SubscriptionHandle _handleTrainingCenterLoaded;
    [SerializeField]
    private Canvas _canvas;
    private CanvasGroup _canvasGroup;

    public KSP2MissionManager MissionMgr
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateContextualMenu(GameState currentView) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TutorialRefresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateContextualMenu(MapMode currentMapMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowHeaderBackground(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleBackgroundAnimation(string triggerType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleInvisible(bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OpenEscapeMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnViewChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GlobalHeaderManager() => throw null;
  }
}
