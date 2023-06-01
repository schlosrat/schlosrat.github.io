// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.CloudLightManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VolumeCloud
{
  public class CloudLightManager
  {
    private static CloudLightManager _This;
    public List<CloudLightManager.LightInfo> LightInfoList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CloudLightManager Instance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CloudLightManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CloudLightManager.LightInfo GetLightInfo(Light light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CloudLightManager.LightInfo AddLightInfo(Light light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddLightInfo(Light light, RenderTexture shadowMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsNewLight(Light light, ref CloudLightManager.LightInfo lightInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddCommandBuffer(ref CloudLightManager.LightInfo lightInfo) => throw null;

    public class LightInfo
    {
      public Light light;
      public RenderTexture shadowMap;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LightInfo() => throw null;
    }
  }
}
