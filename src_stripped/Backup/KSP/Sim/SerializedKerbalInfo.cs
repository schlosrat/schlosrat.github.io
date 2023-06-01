// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedKerbalInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
