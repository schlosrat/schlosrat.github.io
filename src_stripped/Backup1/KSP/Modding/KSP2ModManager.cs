// Decompiled with JetBrains decompiler
// Type: KSP.Modding.KSP2ModManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.ScriptInterop;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modding
{
  public class KSP2ModManager : KerbalMonoBehaviour
  {
    public const string DIALOG_PREFAB = "ModManagerDialog.prefab";
    public List<KSP2Mod> currentMods;
    public static readonly Version MinAPISupported;
    public static readonly Version CurrentAPISupported;
    private List<Version> deprecatedAPIs;
    private List<Version> invalidAPIs;
    private List<IVersionedAPI> versionedAPIs;

    public List<KSP2Mod> CurrentMods
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<Version> DeprecatedAPIs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<Version> InvalidAPIs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<IVersionedAPI> VersionedAPIs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LoadMod(int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LoadAllMods() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UnloadMod(int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ReloadMod(int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RefreshModList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitVersionedAPIs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IVersionedAPI GetAPI(Version apiVersion) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleModManagerDialogMessageHandler(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleModManagerDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool script_LoadMods() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void script_ShowModList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void script_DebugModEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void script_ShowModDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogModMessage(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogModError(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2ModManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static KSP2ModManager() => throw null;
  }
}
