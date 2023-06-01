// Decompiled with JetBrains decompiler
// Type: KSP.Messages.AudioCueMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.VFX;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/CFVS/AudioCueMessage", true, "Base type of audio cue", "")]
  public class AudioCueMessage : CFXSMessageBase
  {
    public string EventName;
    public bool IsStopEvent;
    public SFXEventType SfxEventType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AudioCueMessage() => throw null;
  }
}
