// Decompiled with JetBrains decompiler
// Type: KSP.Messages.AudioCueMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
