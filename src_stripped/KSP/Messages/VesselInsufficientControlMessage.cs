﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselInsufficientControlMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Vessel/VesselInsufficientControlMessage", true, "Player's vehicle has lost sufficient control", "")]
  public class VesselInsufficientControlMessage : VesselMessage
  {
    public string ControlStateMessage;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselInsufficientControlMessage() => throw null;
  }
}
