// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedSessionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
