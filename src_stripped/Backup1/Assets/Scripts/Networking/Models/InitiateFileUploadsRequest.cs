// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Networking.Models.InitiateFileUploadsRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
