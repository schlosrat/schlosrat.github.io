// Decompiled with JetBrains decompiler
// Type: KSP.Api.IContextListProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;

namespace KSP.Api
{
  public interface IContextListProperty
  {
    event Action OnListChanged;

    IDataContextReadonly HierarchyParent { get; }

    IReadOnlyList<IDataContextReadonly> Data { get; }

    IDataContextReadonly this[int index] { get; }

    int Count { get; }

    IDataContextReadonly GetIndexedElement(int index, string indexKey = "index");
  }
}
