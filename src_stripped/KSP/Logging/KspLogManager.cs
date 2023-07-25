// Decompiled with JetBrains decompiler
// Type: KSP.Logging.KspLogManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Logging
{
  public class KspLogManager : MonoBehaviour
  {
    public const string BASE_LOG_FILENAME_PREFIX = "Ksp2";
    public const string BASE_LOG_FILENAME_POSTFIX = ".log";
    private const string LogFilterSettingsAssetPath = "LogFilterSettings";
    private static KspLogManager instance;
    private static Application.LogCallback OnLogCallback;
    [SerializeField]
    private bool logToFile;
    [Tooltip("Number of lines to log before flushing the stream")]
    [SerializeField]
    private int flushEvery;
    private int flushCount;
    private StreamWriter fileStream;
    [SerializeField]
    private bool logToMemory;
    [SerializeField]
    [Tooltip("Number of characters per line")]
    private int memoryLogSize;
    private string[] memoryLog;
    private int memoryLogIndex;
    private int memoryLogLength;
    private string lastError;
    private string lastStackTrace;
    public KspLogManager.OnMemoryLogUpdatedEvent OnMemoryLogUpdated;
    public KspLog logger;
    [SerializeField]
    private LogFilterSettings logFilterSettings;

    public static KspLogManager Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int MemoryLogSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string[] MemoryLog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int MemoryLogIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int MemoryLogLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string LastError
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string LastStackTrace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public LogFilterSettings LogFilterSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~KspLogManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GenerateLogFilenameFullpath() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLoggerSettings(KspLog logger) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LogHeader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LogRenderTextureFormats() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LogCallback(string logString, string stackTrace, LogType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LogToFile(string logString, string stackTrace, LogType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SubstituteDebugLog(
      string sourceMethod,
      string logString,
      string stackTrace,
      LogType type)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LogToMemory(string logString, string stackTrace, LogType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string TimeString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string ConvertLineEndings(string input, string prefix = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddLogCallback(Application.LogCallback method) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RemoveLogCallback(Application.LogCallback method) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KspLogManager() => throw null;

    public delegate void OnMemoryLogUpdatedEvent(string log);
  }
}
