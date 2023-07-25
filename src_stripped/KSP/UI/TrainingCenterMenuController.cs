// Decompiled with JetBrains decompiler
// Type: KSP.UI.TrainingCenterMenuController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UI.Control;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace KSP.UI
{
  [DisableCustomEditorBase]
  [RequireComponent(typeof (CanvasGroup))]
  public class TrainingCenterMenuController : KerbalMonoBehaviour
  {
    private const string TUTORIAL_TITLE_LOCALIZATION_PATH = "Tutorials/Titles/";
    private const string LESSON_DESCRIPTION_LOCALIZATION_PATH = "Tutorials/Lessons/Descriptions/";
    private const string TRAINING_CENTER_PREFIX = "Menu/TrainingCenter/";
    private const string NO_LESSONS_COMPLETED_DEFAULT = "0";
    private const string LESSONS_COMPLETED_PARTITION = "/";
    public static string BackgroundAssetName;
    public static string BackgroundSceneName;
    public static GameObject TrainingCenterBackgroundInstance;
    public static Scene BackgroundScene;
    public static Camera TrainingCenterBackgroundInstanceCamera;
    public static EnvironmentLightingProfile TrainingCenterLightingProfile;
    public static EnvironmentLightingProfile PreviousLightingProfile;
    public TutorialIcon[] TutorialIcons;
    public TutorialFeatureIcon[] TutorialFeatureIcons;
    public LessonIcon[] LessonsIcons;
    public ProgressTutorialIcon[] ProgressTutorialIcons;
    public ProgressLessonIcon[] ProgressLessonIcons;
    [Header("Prefabs")]
    public ContextBindRoot TutorialItemPrefab;
    public ContextBindRoot LessonItemPrefab;
    [Header("BindRoots")]
    public ContextBindRoot UiRoot;
    [Header("References")]
    public SyncToggleGroupWithChildren TutorialsContent;
    public ToggleGroupExtended TutorialToggleGroup;
    [SerializeField]
    private GameObject[] _subMenuElements;
    private MainTutorialsItem[] _tutorials;
    private SubTutorialsItem[] _lessons;
    private CanvasGroup _canvasGroup;
    private bool _isInitialized;
    private TutorialsAndLessonsContextData _data;
    private bool _isMenuVisible;
    private Property<string> _agencyName;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsSubMenuVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVisible(bool isVisible = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSubMenuVisible(bool isVisible = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowTrainingCenterCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleTrainingCenterScene(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExitTrainingCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DismissDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDismissDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MissionReset(string ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MissionActivated(string ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateElements() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RelocalizeText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TrainingCenterMenuController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TrainingCenterMenuController() => throw null;
  }
}
