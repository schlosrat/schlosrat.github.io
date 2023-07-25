// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Factory.IClassFactory`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.Sim.Factory
{
  public interface IClassFactory<C> where C : class
  {
    C ClassFromData<D>(D data, params object[] additionalParams);

    C ClassFromData(Type dataType, object data, params object[] additionalParams);

    C ClassFromDataCustom(Type dataType, object data, params object[] additionalParams);
  }
}
