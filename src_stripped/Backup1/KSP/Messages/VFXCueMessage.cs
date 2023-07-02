// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VFXCueMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.VFX;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/CFVS/VFXCueMessage", true, "Base type of VFX cue", "")]
  public class VFXCueMessage : CFXSMessageBase
  {
    public VFXEventType FXEventType;
    public GameObject FXPrefabOverride;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VFXCueMessage() => throw null;
  }
}
