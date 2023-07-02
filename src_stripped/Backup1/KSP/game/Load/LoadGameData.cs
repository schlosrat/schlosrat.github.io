// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.LoadGameData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
