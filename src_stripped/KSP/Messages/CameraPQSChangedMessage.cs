// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CameraPQSChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/CurrentPQSChangedMessage", true, "The observed PQS planet has changed", "")]
  public class CameraPQSChangedMessage : CameraMessageBase
  {
    public string BodyName;
    public PQS PqsReference;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraPQSChangedMessage() => throw null;
  }
}
