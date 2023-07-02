// Decompiled with JetBrains decompiler
// Type: KSP.Api.IListProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
