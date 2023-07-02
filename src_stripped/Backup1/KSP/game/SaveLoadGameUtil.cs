// Decompiled with JetBrains decompiler
// Type: KSP.Game.SaveLoadGameUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public static class SaveLoadGameUtil
  {
    private static List<SaveLoadGameUtil.MPLoadingLogEntry> _mpLoadingLogEntryList;
    private static bool _mpLoadingLogRunning;
    private static bool _mpLoadingLogToFile;

    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool MPLoadingLogRunning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool MPLoadingLogToFile
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SaveLoadGameUtil.MPLoadingLogEntry> GetMPLoadingLogEntryList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DebugMPLoadingLogWriteLineToFile(string line) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void StartMPLoadingLogMaybe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void StopMPLoadingLogMaybe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogToMPLoadingLogMaybe(
      SaveLoadGameUtil.MPLoadingLogEntryType mpLoadingLogEntryType,
      long ms,
      string line)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogToMPLoadingLogMaybe(
      SaveLoadGameUtil.MPLoadingLogEntryType mpLoadingLogEntryType,
      string line)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FlushMPLoadingLogMaybe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameState GetMyStartingGameStateFromSavedGame(SerializedSavedGame savedGame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameState GetMyHistoricalGameStateFromSavedGame(SerializedSavedGame savedGame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IGGuid GetMyActiveVesselGuidFromSavedGame(SerializedSavedGame savedGame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetMyActiveLocalSpaceBodyFromSavedGame(SerializedSavedGame savedGame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IGGuid GetMyObservedSimObjectGuidFromSavedGame(SerializedSavedGame savedGame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetMyActiveCameraInfo(
      out SerializedActiveCameraInfo serializedActiveCameraInfoOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerializedActiveCameraInfo GetMyActiveCameraInfoFromSavedGame(
      SerializedSavedGame savedGame)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetMyFlightControlStateToSavedGame(
      SerializedSavedGame savedGame,
      SerializedFlightControlState serializedFlightControlState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerializedFlightControlState GetMyFlightCtrlStateFromSavedGame(
      SerializedSavedGame savedGame)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetMyLastOABWorkspaceSnapshotToSavedGame(
      SerializedSavedGame savedGame,
      OABHistoricalSnapshot lastOABWorkspaceSnapshot)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OABHistoricalSnapshot GetMyLastOABWorkspaceSnapshotFromSavedData(
      SerializedSavedGame savedGame)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerializedOABConfig GetMyLastOABConfigFromSavedData(SerializedSavedGame savedGame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetMyActiveVesselNameToSavedGame(
      SerializedSavedGame savedGame,
      string activeVesselName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetMyActiveVesselGuidToSavedGame(
      SerializedSavedGame savedGame,
      IGGuid activeVesselGuid)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SaveLoadGameUtil() => throw null;

    public enum MPLoadingLogEntryType
    {
      None,
      Action,
      Info,
      Heartbeat,
      Disconnect,
    }

    public class MPLoadingLogEntry
    {
      public const SaveLoadGameUtil.MPLoadingLogEntryType DEFAULT_MP_LOADING_LOG_ENTRY_TYPE = SaveLoadGameUtil.MPLoadingLogEntryType.None;
      public const long DEFAULT_TIME_STAMP = 0;
      public const long DEFAULT_DELTA = -1;
      public const long DEFAULT_MS = -1;
      public const string DEFAULT_LINE = "";
      private SaveLoadGameUtil.MPLoadingLogEntryType _mpLoadingLogEntryType;
      private long _timeStamp;
      private long _delta;
      private long _ms;
      private string _line;

      public SaveLoadGameUtil.MPLoadingLogEntryType MPLoadingLogEntryType
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public long TimeStamp
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public string TimeStampString
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public long Delta
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public string DeltaString
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public long MS
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public string MSString
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public string Line
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public MPLoadingLogEntry(
        SaveLoadGameUtil.MPLoadingLogEntryType mpLoadingLogEntryType,
        long timeStamp,
        long delta,
        long ms,
        string line)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string GetLogToFileLineString() => throw null;
    }
  }
}
