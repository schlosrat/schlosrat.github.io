// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedVesselToTravelID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
