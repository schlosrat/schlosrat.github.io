// Decompiled with JetBrains decompiler
// Type: KSP.UI.LaunchLocationItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Sim.impl;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class LaunchLocationItem : KerbalMonoBehaviour
  {
    private const string LAUNCH_LOCATION_PREFIX = "Menu/VAB/";
    private const string RECOVERY_MESSAGE_TITLE_LOC_KEY = "Menu/VAB/RecoveryMessageBox/Title";
    private const string RECOVERY_MESSAGE_BODY_LOC_KEY = "Menu/VAB/RecoveryMessageBox/Body";
    private const string RECOVER_BUTTON_LOC_KEY = "Menu/VAB/RecoveryMessageBox/RecoverButton";
    private const string CANCEL_RECOVERY_BUTTON_LOC_KEY = "Menu/VAB/RecoveryMessageBox/CancelRecoveryButton";
    private const int INDEX_NOT_FOUND = -1;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    [Space]
    private ToggleExtended _toggle;
    [Header("Button Actions")]
    [SerializeField]
    private GameObject _select;
    [SerializeField]
    private GameObject _selected;
    [SerializeField]
    private GameObject _recoverable;
    [SerializeField]
    private GameObject _recoveryRequired;
    [SerializeField]
    private DOTweenAnimation _selectedAnimation;
    [SerializeField]
    private DOTweenAnimation _deselectedAnimation;
    private DataContext _dropdownOptiondataContext;
    private LaunchLocationManager _owner;
    private List<VesselComponent> _nearbyVessels;
    private List<LaunchLocationItem> _launchLocationItems;
    private Property<string> _optionName;
    private Property<string> _vesselName;
    private Property<bool> _isVesselRecoverable;

    public string OptionLabel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public LaunchsiteOrientation LaunchpadOrientation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public OABProvider.LaunchLocation AssociatedLaunchpad
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsLaunchpadAvailable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsLaunchpadRecoveryRequired
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public LaunchLocationManager LaunchLocationManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Toggle Toggle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      LaunchLocationManager owner,
      string optionLabel,
      LaunchsiteOrientation orientation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLaunchpadAvailability() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteFileAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAsSelectedOption(bool isVesselRecoveryRequired) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleWarningModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecoverVesselFromLaunchLocation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CheckIsLaunchpadRecoveryRequired() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DismissWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleItemSelection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleItemRecoveryRequired() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleItemRecoveryRequiredSelection(int requiredRecoveryIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleRecoverySelection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleItemDeselection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchLocationItem() => throw null;
  }
}
