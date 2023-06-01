﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.IChatBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.UI
{
  public interface IChatBox
  {
    Action<ChatMessageType, string> OnMessageAdded { get; set; }

    string[] Messages { get; }

    void AddMessage(ChatMessageType type, string msg);
  }
}