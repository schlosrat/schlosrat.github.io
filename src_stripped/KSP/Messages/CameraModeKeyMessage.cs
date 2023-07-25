// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CameraModeKeyMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/CameraModeKeyMessage", false, "The basic camera rig updates the camera mode.", "")]
  public class CameraModeKeyMessage : CameraMessageBase
  {
    public string CameraMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraModeKeyMessage() => throw null;
  }
}
