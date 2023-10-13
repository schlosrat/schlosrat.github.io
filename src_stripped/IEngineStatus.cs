// Decompiled with JetBrains decompiler
// Type: IEngineStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Modules;

public interface IEngineStatus
{
  bool isOperational { get; }

  float normalizedOutput { get; }

  float throttleSetting { get; }

  string engineName { get; }

  string engineDisplayName { get; }

  Data_Engine.EngineForce AverageEngineForce { get; }
}
