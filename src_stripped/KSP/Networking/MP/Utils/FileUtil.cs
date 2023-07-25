// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.FileUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Networking.MP.Utils
{
  public static class FileUtil
  {
    private static string gTempLogFilesDirectoryPrefix;
    private static string gPersistentLogFilesDirectoryPrefix;
    private static string gPersistentDataFilesDirectoryPrefix;
    private static ConcurrentDictionary<string, bool> gFirstTimeDict;
    private static ConcurrentDictionary<string, object> gLockObjectDict;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetTempLogFilesDirectoryPrefix(string tempLogFilesDirectoryPrefix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetTempLogFilesDirectoryPrefix() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetPersistentFilesDirectoryPrefix(string persistentLogFilesDirectoryPrefix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPersistentFilesDirectoryPrefix() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetPersistentDataFilesDirectoryPrefix(
      string persistentDataFilesDirectoryPrefix)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetPersistentDataFilesDirectoryPrefix() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetFullPathKey(string fullPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool FixFullPath(ref string fullPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsFirstTime(string fullPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ClearFirstTimeFlag(string fileFullPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object GetFileLockObject(string fullpath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PrepForFirstTimeNewFile(string fullpath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogLineToFile(string fullPath, string line) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool DeleteFile(string fullpath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool EnsureDirectoryExists(string directory) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool EnsureParentDirectoryExists(string fullpath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> GetListOfFilesInDirectory(string directory) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool EmptyDirectory(string directory) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WriteLineToFile(
      string fullPath,
      bool append,
      Encoding encoding,
      string str)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool WriteLineToFile(string fullPath, string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SaveStringToUnityPlayerPrefs(string key, string stringValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool LoadStringToUnityPlayerPrefs(
      string key,
      ref string stringValueRef,
      string defaultValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SaveStringToFile(string fullpath, string stringValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool LoadFileAsString(
      string fullpath,
      ref string stringValueRef,
      string defaultValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static FileUtil() => throw null;
  }
}
