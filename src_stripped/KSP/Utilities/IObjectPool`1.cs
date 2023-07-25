// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.IObjectPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.Utilities
{
  public interface IObjectPool<T> : IDisposable
  {
    T FetchInstance();

    void ReleaseInstance(T targetInstance);

    void ReleaseAllActive();
  }
}
