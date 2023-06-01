// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Social.Models.Friend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Social.Models
{
  public class Friend
  {
    [JsonProperty("FriendPlayFabId")]
    public string FriendPlayFabId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [JsonProperty("TitleDisplayName")]
    public string TitleDisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [JsonProperty("Username", NullValueHandling = NullValueHandling.Ignore)]
    public string Username
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Friend() => throw null;
  }
}
