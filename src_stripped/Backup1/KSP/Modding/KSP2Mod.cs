// Decompiled with JetBrains decompiler
// Type: KSP.Modding.KSP2Mod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;

namespace KSP.Modding
{
  public class KSP2Mod
  {
    private int id;
    private static int nextID;
    private IResourceLocator _resourceLocator;
    private KSP2ModType modType;
    private KSP2ModState currentState;
    public string ModRootPath;
    [JsonProperty]
    public string EntryPoint;
    private IKSP2ModCore modCore;
    private Coroutine _loadCatalogCoroutine;

    public int ID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int GetNextID() => throw null;

    private KSP2ModManager modManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KSP2ModType ModType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KSP2ModState CurrentState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonProperty]
    [JsonConverter(typeof (VersionConverter))]
    public Version APIVersion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [JsonProperty]
    [JsonConverter(typeof (VersionConverter))]
    public Version ModVersion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [JsonProperty]
    public string ModName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [JsonProperty]
    public string ModAuthor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [JsonProperty]
    public string ModDescription
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [JsonProperty]
    public string Catalog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Load() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator LoadCatalog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExecuteEvent(string eventText) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2Mod() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static KSP2Mod() => throw null;
  }
}
