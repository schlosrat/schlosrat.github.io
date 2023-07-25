// Decompiled with JetBrains decompiler
// Type: I2.Loc.PersistentStorage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public static class PersistentStorage
  {
    private static I2CustomPersistentStorage mStorage;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetSetting_String(string key, string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSetting_String(string key, string defaultValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DeleteSetting(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HasSetting(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ForceSaveSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanAccessFiles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SaveFile(
      PersistentStorage.eFileType fileType,
      string fileName,
      string data,
      bool logExceptions = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string LoadFile(
      PersistentStorage.eFileType fileType,
      string fileName,
      bool logExceptions = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool DeleteFile(
      PersistentStorage.eFileType fileType,
      string fileName,
      bool logExceptions = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HasFile(
      PersistentStorage.eFileType fileType,
      string fileName,
      bool logExceptions = true)
    {
      throw null;
    }

    public enum eFileType
    {
      Raw,
      Persistent,
      Temporal,
      Streaming,
    }
  }
}
