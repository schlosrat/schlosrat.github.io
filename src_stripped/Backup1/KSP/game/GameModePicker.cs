// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameModePicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class GameModePicker : KerbalMonoBehaviour
  {
    private const string MODE_SPRITE_SUFFIX = ".png";
    [SerializeField]
    private GameObject _gameModeButtonPrefab;
    [SerializeField]
    private RectTransform _contentParent;
    [SerializeField]
    private string _defaultSelection;
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private ToggleGroup _toggleGroup;
    private GameModeManager _gameModeManager;
    private CreateCampaignMenu _createCampaignMenu;
    private IReadOnlyList<string> _availableModes;
    private List<(string id, GameModeButtonContext context, ToggleExtended toggle)> _modeButtons;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Enable(CreateCampaignMenu createCampaignMenu, string modeOnEnable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateGameModeButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SelectGameMode(string modeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateButtonSelection(string selectedModeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetGameModeSprite(GameModeButtonContext buttonContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameModePicker() => throw null;
  }
}
