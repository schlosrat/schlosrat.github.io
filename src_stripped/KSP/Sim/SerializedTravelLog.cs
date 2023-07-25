// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedTravelLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedTravelLog
  {
    public List<SerializedTravelObject> Objects;
    public List<SerializedTravelObjectEvent> ObjectEvents;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedTravelLog() => throw null;
  }
}
