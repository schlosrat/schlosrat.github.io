// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedTravelLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    public SerializedTravelFirsts Firsts;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedTravelLog() => throw null;
  }
}
