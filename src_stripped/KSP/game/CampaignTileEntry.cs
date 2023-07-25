// Decompiled with JetBrains decompiler
// Type: KSP.Game.CampaignTileEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class CampaignTileEntry : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private Property<string> _labelCampaignName;
    private Property<string> _labelCampaignType;
    private Property<string> _labelCampaignGameTime;
    private Property<Sprite> _labelFlagIcon;
    private string _campaignGameTime;
    private CampaignMenu _campaignMenu;
    private CampaignLoadMenu _loadMenu;
    private ExtendedSaveFileInfo _fileInfo;
    private ToggleExtended _toggleExtended;

    public ExtendedSaveFileInfo FileInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string CampaignName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string CampaignLastPlayedTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      ExtendedSaveFileInfo fileInfo,
      CampaignLoadMenu loadMenu,
      CampaignMenu campaignMenu)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCampaignClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignTileEntry() => throw null;
  }
}
