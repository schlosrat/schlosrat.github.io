// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.LightData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.Rendering
{
  public struct LightData
  {
    public Light localLight;
    public Light scaledLight;
    public Renderer scaledPlanetRend;
    public Renderer scaledAtmosphereRend;
    public AtmosphereDataModelComponent atmosphereDataModel;
    public CelestialBodyGIProbeData tempProbe;
    public CelestialBodyGIProbeDataReference scaledGIProbe;
    public MaterialPropertyBlock scaledPropBlock;
    public CelestialBodyLightingData lightingData;
    public CelestialBodyLensFlare lensFlareData;
    public DirectionalLightShadowController shadow;
  }
}
