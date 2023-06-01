// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PartAddedToFavorites
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/PartAddedToFavorites", true, "A part in the OAB is added to favorites by a user with something like middle mouse click", "")]
  public class PartAddedToFavorites : OABMessageBase
  {
    public string PartName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartAddedToFavorites() => throw null;
  }
}
