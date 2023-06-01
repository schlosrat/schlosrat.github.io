// Decompiled with JetBrains decompiler
// Type: KSP.Api.IListProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;

namespace KSP.Api
{
  public interface IListProperty : IList, ICollection, IEnumerable
  {
    event ListChangedEventHandler ListChanged;

    bool AllowInsert { get; }

    bool AllowRemove { get; }

    bool AllowMove { get; }

    bool AllowTransfer { get; }

    void MoveElement(int indexFrom, int indexTo);

    void TransferElement(IListProperty newList, int indexFrom, int indexTo);
  }
}
