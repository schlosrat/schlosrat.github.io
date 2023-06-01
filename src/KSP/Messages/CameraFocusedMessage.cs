// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CameraFocusedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/CameraFocusedMessage", false, "Fires when the camera is focused on a part by the user in the OAB.", "")]
  public class CameraFocusedMessage : CameraMessageBase
  {
    public IObjectAssemblyPart TargetPart;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraFocusedMessage() => throw null;
  }
}
