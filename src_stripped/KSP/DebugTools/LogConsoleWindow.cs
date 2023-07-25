// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.LogConsoleWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  public class LogConsoleWindow : KerbalMonoBehaviour
  {
    private static readonly string PREFAB_KEY;
    private static LogConsoleWindow Instance;
    [SerializeField]
    private LogList _list;
    [SerializeField]
    private TMP_InputField _detail;
    [SerializeField]
    private Toggle _infoToggle;
    [SerializeField]
    private Toggle _warnToggle;
    [SerializeField]
    private Toggle _errToggle;
    [SerializeField]
    private TMP_InputField _maxMessages;
    [SerializeField]
    private Toggle _notificationToggle;
    private static object _logEntriesLock;
    private static Queue<LogEntry> _logEntries;
    private static int _maxLogEntries;
    private static bool _hasLogEntriesChanged;
    private static bool _shouldCaptureInfo;
    private static bool _shouldCaptureWarn;
    private static bool _shouldCaptureErr;
    private static bool _shouldDisplayErrorNotification;
    private bool _isUpdatingUiFromState;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RegisterLogMessageReceiver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Application_logMessageReceivedThreaded(
      string condition,
      string stackTrace,
      LogType type)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void HandleShouldDisplayErrorMessage(string condition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowDetail(LogEntry entry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateStateFromUi() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateUiFromState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogConsoleWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static LogConsoleWindow() => throw null;
  }
}
