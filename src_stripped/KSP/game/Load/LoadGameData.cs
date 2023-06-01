// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadGameData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
