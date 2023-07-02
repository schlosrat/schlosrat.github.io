// Decompiled with JetBrains decompiler
// Type: I2.Loc.ResourceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
  public class ResourceManager : MonoBehaviour
  {
    private static ResourceManager mInstance;
    public List<IResourceManager_Bundles> mBundleManagers;
    public Object[] Assets;
    private readonly Dictionary<string, Object> mResourcesCache;

    public static ResourceManager pInstance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetAsset<T>(string Name) where T : Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Object FindAsset(string Name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasAsset(Object Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T LoadFromResources<T>(string Path) where T : Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T LoadFromBundle<T>(string path) where T : Object => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CleanResourceCache(bool unloadResources = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceManager() => throw null;
  }
}
