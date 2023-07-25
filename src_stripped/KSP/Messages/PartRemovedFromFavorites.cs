// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PartRemovedFromFavorites
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/PartRemovedFromFavorites", true, "A part in the OAB is removed from favorites by a user with something like middle mouse click", "")]
  public class PartRemovedFromFavorites : OABMessageBase
  {
    public string PartName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartRemovedFromFavorites() => throw null;
  }
}
