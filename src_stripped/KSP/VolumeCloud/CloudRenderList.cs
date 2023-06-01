// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.CloudRenderList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VolumeCloud
{
  public class CloudRenderList
  {
    public Action<CloudRenderHelper> OnAddCloudRenderHelper;
    public Action<CloudRenderHelper> OnRemoveCloudRenderHelper;
    private static List<CloudRenderHelper> CloudHelperList;
    public static Dictionary<string, List<GameObject>> scaledCloudsMap;
    private GameManager gameManager;
    private GraphicsManager graphicsManager;
    private static CloudRenderList _This;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CloudRenderList Instance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CloudRenderList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveConfig(VolumeCloudConfiguration config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeConfig(VolumeCloudConfiguration config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCloudConfigChanged(
      VolumeCloudConfiguration selectedConfig,
      VolumeCloudConfiguration fomerConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCloudRenderHelper(CloudRenderHelper cloudHelper) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGraphicsManager(GraphicsManager gm) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnConfigChanged(VolumeCloudConfiguration config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCloudLayerChanged(VolumeCloudConfiguration config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnConfigIniteComplete(VolumeCloudConfiguration config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshScaledCloudLayers(
      ScaledCloudDataModelComponent scaledCloudModel,
      VolumeCloudConfiguration config)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncCloudsConfig(
      ScaledCloudDataModelComponent scaledCloudModel,
      VolumeCloudConfiguration config)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveCloudRenderHelper(CloudRenderHelper cloudHelper) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CloudRenderHelper GetHelperByIndex(int index) => throw null;
  }
}
