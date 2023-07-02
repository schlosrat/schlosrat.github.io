// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.SerializedColonyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Colonies;
using System.Collections.Generic;

namespace KSP.Sim.Definitions
{
  public struct SerializedColonyData
  {
    public List<ActiveFlight> activeFlights;
    public List<DeliveryRoute> deliveryRoutes;
  }
}
