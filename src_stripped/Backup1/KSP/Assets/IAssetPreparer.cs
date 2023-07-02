// Decompiled with JetBrains decompiler
// Type: KSP.Assets.IAssetPreparer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
