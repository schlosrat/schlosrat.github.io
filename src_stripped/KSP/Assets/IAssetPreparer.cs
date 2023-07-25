// Decompiled with JetBrains decompiler
// Type: KSP.Assets.IAssetPreparer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
