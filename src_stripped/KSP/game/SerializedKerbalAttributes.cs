// Decompiled with JetBrains decompiler
// Type: KSP.Game.SerializedKerbalAttributes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace KSP.Game
{
  [Serializable]
  public class SerializedKerbalAttributes
  {
    [FormerlySerializedAs("RawCustomName")]
    public string CustomNameKey;
    public string FirstName;
    [FormerlySerializedAs("SurName")]
    public string Surname;

    [JsonConstructor]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedKerbalAttributes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedKerbalAttributes(KerbalAttributes kerbalAttributes) => throw null;
  }
}
