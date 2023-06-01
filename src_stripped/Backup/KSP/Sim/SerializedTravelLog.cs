// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedTravelLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
