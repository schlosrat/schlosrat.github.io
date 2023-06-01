// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedLocation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;

namespace KSP.Sim
{
  [Serializable]
  public struct SerializedLocation
  {
    public LocationType LocationType;
    public SerializedKeplerOrbit? serializedOrbit;
    public SerializedSurfaceLocation? surfaceLocation;
    public SerializedRigidbodyState? rigidbodyState;
    public IGGuid originatingSimObject;
  }
}
