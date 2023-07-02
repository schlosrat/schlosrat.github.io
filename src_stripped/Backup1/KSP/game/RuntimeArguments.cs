// Decompiled with JetBrains decompiler
// Type: KSP.Game.RuntimeArguments
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class RuntimeArguments
  {
    private static readonly char[] TEST_NAME_DELIMITER;
    private static readonly char[] TEST_ARG_DELIMITER;
    private const float DEFAULT_SCREENSHOTS_INTERVAL = 15f;

    public bool IsMetricsMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string TestReportOutputDirectory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string TestScreenShotOutputDirectory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float ScreenshotIntervalSeconds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RuntimeArguments CreateFromArguments(string inputArgs = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void LogWarning(string warning) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void LogError(string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ParseCommandLineArguments(params string[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsArgMatch(string arg, string matchingArg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RuntimeArguments() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static RuntimeArguments() => throw null;
  }
}
