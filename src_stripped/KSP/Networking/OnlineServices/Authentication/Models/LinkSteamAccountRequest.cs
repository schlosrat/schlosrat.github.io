// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Authentication.Models.LinkSteamAccountRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Authentication.Models
{
  [Serializable]
  public class LinkSteamAccountRequest
  {
    public string SteamTicket;
    public Dictionary<string, string> CustomTags;
    public bool ForceLink;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LinkSteamAccountRequest() => throw null;
  }
}
