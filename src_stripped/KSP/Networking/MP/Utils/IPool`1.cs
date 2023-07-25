// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.IPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
