// Decompiled with JetBrains decompiler
// Type: KSP.Assets.IAssetPreparer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;

namespace KSP.Assets
{
  public interface IAssetPreparer
  {
    List<Type> foundTypes { get; }

    void log(string formatString, params object[] arguments);

    void error(string formatString, params object[] arguments);

    void prepareTargets(PrepareAssetOptions options, params object[] arguments);

    void unprepareTargets(PrepareAssetOptions options, params object[] arguments);
  }
}
