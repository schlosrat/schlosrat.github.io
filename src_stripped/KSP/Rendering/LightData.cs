// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.LightData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
