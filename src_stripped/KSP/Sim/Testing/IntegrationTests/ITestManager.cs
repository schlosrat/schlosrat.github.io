// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Testing.IntegrationTests.ITestManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
