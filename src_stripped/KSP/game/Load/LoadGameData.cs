// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadGameData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public class LoadGameData
  {
    public SerializedSavedGame SavedGame;
    [NonSerialized]
    public KSP.Sim.Definitions.CelestialBodyProperties[] CelestialBodyProperties;
    [NonSerialized]
    public List<Tuple<string, List<SerializedPart>>> legacyData;
    public long DataLength;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadGameData() => throw null;
  }
}
