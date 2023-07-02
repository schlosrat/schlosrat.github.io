// Decompiled with JetBrains decompiler
// Type: UniLinq.IGrouping`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

namespace UniLinq
{
  public interface IGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable
  {
    TKey Key { get; }
  }
}
