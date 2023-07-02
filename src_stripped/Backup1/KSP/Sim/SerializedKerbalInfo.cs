// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedKerbalInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
