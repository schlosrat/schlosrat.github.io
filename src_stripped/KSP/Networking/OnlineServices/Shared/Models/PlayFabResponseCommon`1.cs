// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Shared.Models.PlayFabResponseCommon`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Shared.Models
{
  public class PlayFabResponseCommon<T>
  {
    [JsonProperty("code")]
    public long Code
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [JsonProperty("errorMessage")]
    public string ErrorMessage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [JsonProperty("status")]
    public string Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [JsonProperty("data")]
    public T Data
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlayFabResponseCommon() => throw null;
  }
}
