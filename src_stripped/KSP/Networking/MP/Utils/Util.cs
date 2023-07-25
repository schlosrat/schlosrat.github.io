// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.Util
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public static class Util
  {
    private static Random gRandom;
    private static bool gApplicationShuttingDown;
    private static object gUniqueIdStringLockObject;
    private static Dictionary<string, ulong> gUniqueIdStringDict;

    public static bool IsApplicationShuttingDown
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnityEditorBreak() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnusedVar<T>(T var) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Nop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DeclareApplicationShuttingDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<string> GetCallStackString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string BuildNameBasedOnInstance(
      string baseNamePrefixString,
      int instanceNumber,
      string postfixString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateUniqueIdString(string baseString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CopyTextToClipboard(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogInfo(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogWarn(string message, [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "", [CallerMemberName] string memberName = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogError(
      string message,
      [CallerLineNumber] int lineNumber = 0,
      [CallerFilePath] string filePath = "",
      [CallerMemberName] string memberName = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogException(
      Exception exception,
      [CallerLineNumber] int lineNumber = 0,
      [CallerFilePath] string filePath = "",
      [CallerMemberName] string memberName = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Clamp<T>(T val, T min, T max) where T : IComparable => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long QuantizeUpOrSameInt64(long val, long quantizeAmount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int QuantizeUpOrSameInt(int val, int quantizeAmount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetRandomNumber(int numValues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetRandomNumber(int min, int max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] GenerateRandomByteArrayOrNullIfZero(int numBytes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] GenerateTestByteArrayOrNullIfZero(int numBytes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char GenerateRandomUpperCaseAlphaNumericChar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateRandomUpperCaseAlphaNumericString(int numCharacters) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char GenerateRandomLowerCaseAlphaNumericChar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateRandomLowerCaseAlphaNumericString(int numCharacters) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char GenerateRandomUpperLowerCaseAlphaNumericChar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateRandomUpperLowerCaseAlphaNumericString(int numCharacters) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetFilePathMemberNameLineNumberString(
      IncludeFlag includeFlags,
      [CallerLineNumber] int lineNumber = 0,
      [CallerFilePath] string filePath = "",
      [CallerMemberName] string memberName = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetIPEndPointFromString(
      string ipEndPointString,
      out IPEndPoint ipEndPointOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateZeroGuidString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateNewGuidStringForAppGuidString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateNewGuidStringForPlayerGuidString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateNewGuidStringForGameServerGuidString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GeneratePlayerNameString(
      bool fetchUserBaseNameFromEnvironment,
      string playerNameStringBase = "Unnamed Player")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<T> GetEnumList<T>(SortOrder sortOrder, params T[] ignoreArray) where T : System.Enum => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ComputeHashString(string sourceString, bool caseSensitive = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ComputePasswordHashString(string password, bool caseSensitive = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] GetConstStringValuesFromClass(Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool FindConstStringValueRepeats(Type type, out string errorStringRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ByteArrayToHexString(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int HexDigitsToValue(char ch1, char ch2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HexStringToByteArray(string hexString, out byte[] byteArrayOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ByteArrayToBase64String(byte[] byteArray) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Base64StringToByteArray(string base64String, out byte[] byteArrayOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] CalculateSha256HashByteArray(string utf8String) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string CalculateSha256HashHexString(string utf8String) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string CalculateSha256HashBase64String(string utf8String) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetEnumFormatString<T>(bool multiline) where T : System.Enum => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetEnumFormatHashString<T>(bool multiline) where T : System.Enum => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DebugFileWriteLine(
      string fullPath,
      string line,
      bool includeLocalDateAndTime = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DebugFileWriteLine(string line) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool OpenURLInExternalBrowser(string url) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Util() => throw null;
  }
}
