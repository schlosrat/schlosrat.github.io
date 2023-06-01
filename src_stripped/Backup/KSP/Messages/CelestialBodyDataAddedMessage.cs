// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CelestialBodyDataAddedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/CelestialBody/CelestialBodyDataAddedMessage", true, "", "")]
  public class CelestialBodyDataAddedMessage : CelestialBodyMessageBase
  {
    public string AddedBodyName;
    public bool IsStar;
    public CelestialBodyLightingData LightingData;
    public CelestialBodyLensFlare LensFlareData;
    public PostProcessData PostProcessData;
    public CelestialBodyRingGroup RingGroup;
    public AtmosphereDataModelComponent AtmosphereDataModel;
    public ScaledCloudDataModelComponent ScaledCloudDataModel;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyDataAddedMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyDataAddedMessage(
      string name,
      bool isStar,
      CelestialBodyLightingData lightingData,
      CelestialBodyLensFlare lensFlareData,
      PostProcessData postProcessData,
      CelestialBodyRingGroup ringGroup,
      AtmosphereDataModelComponent atmoDataModel,
      ScaledCloudDataModelComponent scaledCloudDataModel = null)
    {
      throw null;
    }
  }
}
