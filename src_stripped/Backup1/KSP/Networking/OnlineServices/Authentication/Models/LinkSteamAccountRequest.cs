// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Authentication.Models.LinkSteamAccountRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
