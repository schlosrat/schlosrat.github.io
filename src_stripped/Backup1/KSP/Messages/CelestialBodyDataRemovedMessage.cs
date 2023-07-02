// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CelestialBodyDataRemovedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
