// Decompiled with JetBrains decompiler
// Type: KSP.UI.MissionControlAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace KSP.UI
{
  public class MissionControlAction : KerbalMonoBehaviour
  {
    public static string BackgroundAssetName;
    public static string BackgroundSceneName;
    public const string MISSION_CONTROL_PREFAB = "MissionControl.prefab";
    public const string MISSION_START_NAME = "Main";
    public static Scene BackgroundScene;
    public static GameObject MissionControlBackgroundInstance;
    public static Camera MissionControlBackgroundInstanceCamera;
    public static EnvironmentLightingProfile MissionControlLightingProfile;
    public static EnvironmentLightingProfile PreviousLightingProfile;
    [Header("Prefabs")]
    public ContextBindRoot MissionItemPrefab;
    public ContextBindRoot BindRoot;
    public MissionToggleExtended MissionPrefab;
    public UnityAction UpdateUI;
    private Missionlogic _missionLogic;
    [SerializeField]
    private GameObject _accordionContent;
    private ToggleExtended[] _mission;
    private CanvasGroup _canvasGroup;
    private DataContext _missionControlContext;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionToggleExtended GetTrackedMission() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool isVisible = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExitMissionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DismissMissionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleMissionControlScene(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionControlAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MissionControlAction() => throw null;
  }
}
