// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.IPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;

namespace KSP.Networking.MP.Utils
{
  public interface IPool<T> where T : class
  {
    int AvailableCount { get; }

    void Flush();

    void MakeAvailable(int count);

    T Acquire();

    void AcquireMultiple(ICollection<T> collection, int count);

    void Return(ref T t);
  }
}
