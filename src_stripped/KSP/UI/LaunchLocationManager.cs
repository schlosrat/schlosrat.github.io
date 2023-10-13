// Decompiled with JetBrains decompiler
// Type: KSP.UI.LaunchLocationManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using DG.Tweening;
using KSP.Game;
using KSP.Messages;
using KSP.OAB;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class LaunchLocationManager : KerbalMonoBehaviour
  {
    [SerializeField]
    private ObjectAssemblyHeader _oabHeader;
    [SerializeField]
    private LaunchLocationItem _launchLocationItemTemplate;
    [SerializeField]
    private LaunchLocationOptions[] _contentItems;
    [SerializeField]
    private RectTransform _contentParent;
    [SerializeField]
    private ToggleExtended _launchLocationToggle;
    [SerializeField]
    private SyncToggleGroupWithChildren _syncToggleGroupWithChildren;
    [SerializeField]
    private DOTweenAnimation _launchLocationOpenAnimation;
    private List<LaunchLocationItem> _launchLocationOptions;
    private LaunchLocationItem _currentSelectedOption;
    private ObjectAssemblyBuilder _builder;
    private Camera _workspaceView;
    private bool _isReverted;

    public LaunchLocationItem CurrentSelectedOption
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilder builder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckForVessel(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VesselReverted(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateStageDeltaV(MessageCenterMessage _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatedAutoSelectedLaunchpadVesselLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatedAutoSelectedLaunchpadFirstPartPlaced(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AutoSelectAppropriateLaunchpadForVessel(FirstPartPlacedMessage firstPartPlaced) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetLaunchpadForVessel(OABOrientation oabOrientation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetLaunchpadForRevertedVessel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLaunchLocation(LaunchLocationItem option) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LocalizeOptionName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLaunchButton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchLocationManager() => throw null;
  }
}
