// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  public class VesselMessage : MessageCenterMessage
  {
    [JsonIgnore]
    public VesselComponent Vessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselMessage() => throw null;
  }
}
