// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedVesselToTravelID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedVesselToTravelID
  {
    public Guid VesselId;
    public Guid TravelObjectId;

    [JsonConstructor]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedVesselToTravelID() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedVesselToTravelID(KeyValuePair<IGGuid, IGGuid> mapping) => throw null;
  }
}
