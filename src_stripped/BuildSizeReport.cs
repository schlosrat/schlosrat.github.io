// Decompiled with JetBrains decompiler
// Type: BuildSizeReport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public class BuildSizeReport
{
  private List<BuildSizeElement> sizeReport;
  private string reportsFolder;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public BuildSizeReport() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static BuildSizeElement ProcessReportLine(string reportLine) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CreateBuildSizeReport(string buildPath) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private string GetUnityLogPath() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateGrafanaJson(string buildPath) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static long DirectorySize(DirectoryInfo mainDirectory) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private string GetGrafanaName(string elementName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private string ConvertToMegabytes(string elementValue, string elementUnit) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static long UnixTimestamp(DateTime time) => throw null;
}
