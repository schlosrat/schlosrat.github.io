// Decompiled with JetBrains decompiler
// Type: IEngineStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
