﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedVesselToTravelID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
