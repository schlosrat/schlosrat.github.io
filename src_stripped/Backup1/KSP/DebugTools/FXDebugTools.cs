// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.FXDebugTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using KSP.Utilities;
using KSP.VFX;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  public class FXDebugTools : KerbalMonoBehaviour
  {
    private static readonly string PREFAB_KEY;
    [SerializeField]
    private FXDebugPartItem _simObjectItemPrefab;
    [SerializeField]
    private Transform _partsSimObjectListParent;
    [SerializeField]
    private Transform _vesselsSimObjectListParent;
    [SerializeField]
    private Toggle _toggleProximityLoadUnload;
    [SerializeField]
    private Transform _consoleWindow;
    [SerializeField]
    private TextMeshProUGUI _consoleText;
    private bool _consoleOpen;
    private GameObjectPool<FXDebugPartItem> _simObjectItemPool;
    private bool _forceRefresh;
    public List<FXDebugPartItem> SelectedObjects;
    private static bool _initialActivationState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleWindow() => throw null;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidSimObject(SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnItemReset(FXDebugPartItem simObjectItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceRefresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleProximityLoadUnloadValueChanged(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LogSplashEvent(WaterSplashEventData splashEventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LogInfo_Internal(string info) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogInfo(string info) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearConsole() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleConsole() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowExplosionFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowExplosionFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowEngineFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowEngineFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowDetachFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowDetachFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowSurfaceImpactFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowSurfaceImpactFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowGroundBlastFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowGroundBlastFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowShockConeFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowShockConeFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowContrailsFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowContrailsFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowWingtipVorticesFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowWingtipVorticesFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowReentryFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowReentryFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowPersistantSurfaceContactFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowPersistantSurfaceContactFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowWheelSurfaceFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowWheelSurfaceFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowKerbalPoofFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowKerbalPoofFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowKerbalFootstepFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowKerbalFootstepFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowLaunchSmokeFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowLaunchSmokeFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowLaunchFireFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowLaunchFireFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowLaunchFuelTankIceFX(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetShowLaunchFuelTankIceFX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowVFXTestSuite() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXDebugTools() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static FXDebugTools() => throw null;
  }
}
