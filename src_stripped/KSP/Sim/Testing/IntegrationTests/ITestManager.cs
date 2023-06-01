// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Testing.IntegrationTests.ITestManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.Sim.Testing.IntegrationTests
{
  public interface ITestManager
  {
    string Log { get; }

    event Action<string> OnLogAppended;

    bool AcceptsCommands { get; }

    void EnterCommand(string command);

    void BeginSuite(string suiteName);

    void EndSuite(string suiteName);

    void BeginTestCase(string testCaseName);

    void FailTestCase(string testCaseName, string reason);

    void EndTestCase(string testCaseName);
  }
}
