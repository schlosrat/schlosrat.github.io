// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedKerbalInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedKerbalInfo
  {
    public string NameKey;
    public double EnrollmentUT;
    public string PlayerGuidString;
    public string SimObjectIdString;
    public string SecondaryIdString;
    public int PositionIndex;
    [FormerlySerializedAs("KerbalAttributes")]
    public SerializedKerbalAttributes Attributes;

    [JsonConstructor]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedKerbalInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedKerbalInfo(KerbalInfo info) => throw null;
  }
}
