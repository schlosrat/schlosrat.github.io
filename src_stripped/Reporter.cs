// Decompiled with JetBrains decompiler
// Type: Reporter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reporter : MonoBehaviour
{
  private List<Reporter.Sample> samples;
  private List<Reporter.Log> logs;
  private List<Reporter.Log> collapsedLogs;
  private List<Reporter.Log> currentLog;
  private MultiKeyDictionary<string, string, Reporter.Log> logsDic;
  private Dictionary<string, string> cachedString;
  [HideInInspector]
  public bool show;
  private bool collapse;
  private bool clearOnNewSceneLoaded;
  private bool showTime;
  private bool showScene;
  private bool showMemory;
  private bool showFps;
  private bool showGraph;
  private bool showLog;
  private bool showWarning;
  private bool showError;
  private int numOfLogs;
  private int numOfLogsWarning;
  private int numOfLogsError;
  private int numOfCollapsedLogs;
  private int numOfCollapsedLogsWarning;
  private int numOfCollapsedLogsError;
  private bool showClearOnNewSceneLoadedButton;
  private bool showTimeButton;
  private bool showSceneButton;
  private bool showMemButton;
  private bool showFpsButton;
  private bool showSearchText;
  private bool showCopyButton;
  private bool showSaveButton;
  private string buildDate;
  private string logDate;
  private float logsMemUsage;
  private float graphMemUsage;
  private float gcTotalMemory;
  public string UserData;
  public float fps;
  public string fpsText;
  private Reporter.ReportView currentView;
  private static bool created;
  public Images images;
  private GUIContent clearContent;
  private GUIContent collapseContent;
  private GUIContent clearOnNewSceneContent;
  private GUIContent showTimeContent;
  private GUIContent showSceneContent;
  private GUIContent userContent;
  private GUIContent showMemoryContent;
  private GUIContent softwareContent;
  private GUIContent dateContent;
  private GUIContent showFpsContent;
  private GUIContent infoContent;
  private GUIContent saveLogsContent;
  private GUIContent searchContent;
  private GUIContent copyContent;
  private GUIContent closeContent;
  private GUIContent buildFromContent;
  private GUIContent systemInfoContent;
  private GUIContent graphicsInfoContent;
  private GUIContent backContent;
  private GUIContent logContent;
  private GUIContent warningContent;
  private GUIContent errorContent;
  private GUIStyle barStyle;
  private GUIStyle buttonActiveStyle;
  private GUIStyle nonStyle;
  private GUIStyle lowerLeftFontStyle;
  private GUIStyle backStyle;
  private GUIStyle evenLogStyle;
  private GUIStyle oddLogStyle;
  private GUIStyle logButtonStyle;
  private GUIStyle selectedLogStyle;
  private GUIStyle selectedLogFontStyle;
  private GUIStyle stackLabelStyle;
  private GUIStyle scrollerStyle;
  private GUIStyle searchStyle;
  private GUIStyle sliderBackStyle;
  private GUIStyle sliderThumbStyle;
  private GUISkin toolbarScrollerSkin;
  private GUISkin logScrollerSkin;
  private GUISkin graphScrollerSkin;
  public Vector2 size;
  public float maxSize;
  public int numOfCircleToShow;
  private static string[] scenes;
  private string currentScene;
  private string filterText;
  private string deviceModel;
  private string deviceType;
  private string deviceName;
  private string graphicsMemorySize;
  private string maxTextureSize;
  private string systemMemorySize;
  public bool Initialized;
  private Rect screenRect;
  private Rect toolBarRect;
  private Rect logsRect;
  private Rect stackRect;
  private Rect graphRect;
  private Rect graphMinRect;
  private Rect graphMaxRect;
  private Rect buttomRect;
  private Vector2 stackRectTopLeft;
  private Rect detailRect;
  private Vector2 scrollPosition;
  private Vector2 scrollPosition2;
  private Vector2 toolbarScrollPosition;
  private Reporter.Log selectedLog;
  private float toolbarOldDrag;
  private float oldDrag;
  private float oldDrag2;
  private float oldDrag3;
  private int startIndex;
  private Rect countRect;
  private Rect timeRect;
  private Rect timeLabelRect;
  private Rect sceneRect;
  private Rect sceneLabelRect;
  private Rect memoryRect;
  private Rect memoryLabelRect;
  private Rect fpsRect;
  private Rect fpsLabelRect;
  private GUIContent tempContent;
  private Vector2 infoScrollPosition;
  private Vector2 oldInfoDrag;
  private Rect tempRect;
  private float graphSize;
  private int startFrame;
  private int currentFrame;
  private Vector3 tempVector1;
  private Vector3 tempVector2;
  private Vector2 graphScrollerPos;
  private float maxFpsValue;
  private float minFpsValue;
  private float maxMemoryValue;
  private float minMemoryValue;
  private List<Vector2> gestureDetector;
  private Vector2 gestureSum;
  private float gestureLength;
  private int gestureCount;
  private float lastClickTime;
  private Vector2 startPos;
  private Vector2 downPos;
  private Vector2 mousePosition;
  private int frames;
  private bool firstTime;
  private float lastUpdate;
  private const int requiredFrames = 10;
  private const float updateInterval = 0.25f;
  private List<Reporter.Log> threadedLogs;

  public float TotalMemUsage
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void addSample() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void initializeStyle() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void clear() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void calculateCurrentLog() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DrawInfo() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void drawInfo_enableDisableToolBarButtons() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DrawReport() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void drawToolBar() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DrawLogs() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void drawGraph() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void drawStack() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnGUIDraw() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool isGestureDone() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool isDoubleClickDone() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector2 getDownPos() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector2 getDrag() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void calculateStartIndex() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void doShow() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CaptureLog(string condition, string stacktrace, LogType type) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddLog(string condition, string stacktrace, LogType type) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CaptureLogThread(string condition, string stacktrace, LogType type) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void _OnLevelWasLoaded(Scene _null1, LoadSceneMode _null2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnApplicationQuit() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator readInfo() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SaveLogsToDevice() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Reporter() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static Reporter() => throw null;

  public enum _LogType
  {
    Error,
    Assert,
    Warning,
    Log,
    Exception,
  }

  public class Sample
  {
    public float time;
    public byte loadedScene;
    public float memory;
    public float fps;
    public string fpsText;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float MemSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetSceneName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Sample() => throw null;
  }

  public class Log
  {
    public int count;
    public Reporter._LogType logType;
    public string condition;
    public string stacktrace;
    public int sampleId;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Reporter.Log CreateCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMemoryUsage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Log() => throw null;
  }

  private enum ReportView
  {
    None,
    Logs,
    Info,
    Snapshot,
  }

  private enum DetailView
  {
    None,
    StackTrace,
    Graph,
  }
}
