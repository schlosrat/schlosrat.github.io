// Decompiled with JetBrains decompiler
// Type: KSP.Game.CampaignMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class CampaignMenu : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [Space]
    [Header("Singleplayer Campaign Menu")]
    [SerializeField]
    private GameObject _campaignSinglePlayerCampaignMenu;
    [SerializeField]
    private GameObject _campaignScrollViewLastPlayedDate;
    [SerializeField]
    private GameObject _campaignScrollViewContentLastPlayedDate;
    [SerializeField]
    private CampaignTileEntry _campaignEntryPrefab;
    [SerializeField]
    private ButtonExtended _deleteCampaignButton;
    [SerializeField]
    [Header("Sub Menus")]
    private GameObject _createCampaignMenu;
    [SerializeField]
    private CampaignLoadMenu _campaignLoadMenu;
    [Header("DOtween Animations")]
    [SerializeField]
    private float _animationDelay;
    [SerializeField]
    private DOTweenAnimation _showAnimation;
    [SerializeField]
    private DOTweenAnimation _hideAnimation;
    [Header("Warning Modal")]
    [SerializeField]
    private CanvasGroup _campaignDeletionWarning;
    private DataContext _dataContext;
    private Property<bool> _shouldIncludeMultiplayerMenuOption;
    private List<List<SaveFileInfo>> _campaignSavesList;
    private List<List<SaveFileInfo>> _campaignSavesListLastPlayed;
    private CanvasGroup _canvasGroup;
    private CanvasGroup _loadMenuCanvasGroup;
    private IEnumerator _waitForAnimation;
    private CampaignTileEntry _currentSelectedTileEntry;
    private CampaignTileEntry _lastPlayedTileEntry;
    private CampaignTileEntry _firstSortedByNameTileEntry;
    private Dictionary<string, CampaignTileEntry> _campaignTiles;
    private List<CampaignTileEntry> _campaignEntryTiles;
    private CampaignMenu.CampaignSavesSortType _currentSortType;
    private bool _isFirstSortByDate;
    private bool _isFirstSortByName;
    private bool _isInitialized;

    public CampaignTileEntry CurrentSelectedTileEntry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator WaitForHideAnimationToFinish(float delay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSinglePlayerMultiplayerModifications() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillCampaignScrollView(
      List<List<SaveFileInfo>> campaignList,
      GameObject campaignScrollView)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BackToMainMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartNewCampaignMenu() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SwapSortMethod() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortCampaignByName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortCampaignByDate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartCampaignDeletionFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfirmDeleteCampaignWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CancelDeleteCampaignWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteCampaignFolder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignMenu() => throw null;

    private enum CampaignSavesSortType : byte
    {
      None,
      Name,
      Date,
    }
  }
}
