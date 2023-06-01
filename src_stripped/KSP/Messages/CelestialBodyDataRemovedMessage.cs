// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CelestialBodyDataRemovedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/CelestialBody/CelestialBodyDataRemovedMessage", false, "", "")]
  public class CelestialBodyDataRemovedMessage : CelestialBodyMessageBase
  {
    public AtmosphereDataModelComponent AtmosphereDataModel;
    public ScaledCloudDataModelComponent ScaledCloudDataModel;

    public string RemovedBodyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyDataRemovedMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyDataRemovedMessage(
      string removedBodyName,
      AtmosphereDataModelComponent atmoDataModel)
    {
      throw null;
    }
  }
}
