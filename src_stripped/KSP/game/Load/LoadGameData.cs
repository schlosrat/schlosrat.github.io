// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadGameData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadGameData() => throw null;
  }
}
