// Decompiled with JetBrains decompiler
// Type: KSP.Messages.AutoModeCameraContextMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/AutoModeCameraContextMessage", false, "The camera context used when being set in auto-mode.", "")]
  public class AutoModeCameraContextMessage : CameraMessageBase
  {
    public string CameraName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AutoModeCameraContextMessage() => throw null;
  }
}
