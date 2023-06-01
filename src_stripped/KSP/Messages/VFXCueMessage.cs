// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VFXCueMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
