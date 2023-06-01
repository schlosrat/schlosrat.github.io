// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Factory.IClassFactory`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
