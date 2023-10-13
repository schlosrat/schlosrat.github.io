// Decompiled with JetBrains decompiler
// Type: Versioning
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

[Obsolete("Exposes instance via singleton which is obsolete in most cases")]
public class Versioning : VersioningBase
{
  [Obsolete("Exposes instance via singleton which is obsolete in most cases", true)]
  public static Versioning fetch;
  public string titleShort;
  public string title;
  public int versionMajor;
  public int versionMinor;
  public int revision;
  public int experimental;
  public int buildID;
  public bool beta;
  public bool prerelease;
  public bool isReleaseBuild;
  public bool isSteam;
  private string versionString;
  private static string architecture;
  private string patcherDLRoot;
  public bool test;
  public static string Language;
  public static bool promptNewVersion;
  private bool isPatch;
  private string windowTitle;
  public GUISkin newVersionWindowSkin;
  public bool dontShowAgain;

  public static int version_major
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static int version_minor
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static int Revision
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static int Experimental
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static int BuildID
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool isBeta
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool isPrerelease
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool IsSteam
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static string TitleShort
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static string Title
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool IsReleaseBuild
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static string VersionString
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override string GetVersion() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string GetVersionStringWithExperimental() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string GetVersionStringWithPrerelease() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string GetVersionStringFull() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void OnAwake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static byte[] FileMD5Bytes(string file) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string FileMD5String(string file) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string BytesToHex(byte[] b) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdatePatcher() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private string GetOSCode() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private string GetUpdateChannel() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PatcherDownloaded(object sender, AsyncCompletedEventArgs e) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateGame() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void QuitAndStartPatcher() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Versioning() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static Versioning() => throw null;
}
