// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedLocation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
