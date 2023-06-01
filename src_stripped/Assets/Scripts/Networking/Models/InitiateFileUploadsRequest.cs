// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Networking.Models.InitiateFileUploadsRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Assets.Scripts.Networking.Models
{
  public class InitiateFileUploadsRequest
  {
    [JsonProperty("FileNames")]
    public List<string> FileNames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [JsonProperty("Entity")]
    public Entity Entity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InitiateFileUploadsRequest() => throw null;
  }
}
