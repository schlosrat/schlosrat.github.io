// Decompiled with JetBrains decompiler
// Type: KSP.Game.SerializedKerbalAttributes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
