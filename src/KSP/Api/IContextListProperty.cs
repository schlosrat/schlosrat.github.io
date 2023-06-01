// Decompiled with JetBrains decompiler
// Type: KSP.Api.IContextListProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
