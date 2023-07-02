// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.LightData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
