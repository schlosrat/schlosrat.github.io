// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedSessionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedSessionManager
  {
    [JsonProperty("DifficultyOptions")]
    public DifficultyOptionsData DifficultyOptions;
    [JsonProperty("DefaultDifficultyOptions")]
    public DifficultyOptionsData DefaultDifficultyOptions;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSessionManager() => throw null;
  }
}
