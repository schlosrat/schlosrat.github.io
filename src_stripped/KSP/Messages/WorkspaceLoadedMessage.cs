// Decompiled with JetBrains decompiler
// Type: KSP.Messages.WorkspaceLoadedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/WorkspaceLoadedMessage", false, "A workspace has been loaded", "")]
  public class WorkspaceLoadedMessage : OABMessageBase
  {
    public OABLoadDialogExistingSave existingSave;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WorkspaceLoadedMessage() => throw null;
  }
}
