// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.AppInstanceTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace KSP.Networking.MP.Utils
{
  public class AppInstanceTracker : IDisposable
  {
    private static AppInstanceTracker gAppInstance;
    private static AppInstanceTracker gDirInstance;
    public const int NO_INSTANCE_NUMBER = 0;
    public const string NO_NAME = "N/A";
    public const string NO_INSTANCE_NAME = "N/A";
    public const string SEMAPHORE_NAME_PREFIX = "InterceptGames";
    private string _uniqueString;
    private int _instanceNumber;
    private string _name;
    private string _instanceName;
    private Semaphore _semaphore;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AppInstanceTracker CreateAppInstanceTracker(
      string baseName,
      AppInstanceTrackerType appInstanceTrackerType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string FixNameString(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GenerateSemaphoreName(string name, int counter) => throw null;

    public static AppInstanceTracker AppInstance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static AppInstanceTracker DirInstance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string UniqueString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int InstanceNumber
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string InstanceName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AppInstanceTracker(string name = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~AppInstanceTracker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Init(string name = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetupSemaphore(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TeardownSemaphore() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AppInstanceTracker() => throw null;
  }
}
