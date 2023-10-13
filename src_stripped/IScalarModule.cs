// Decompiled with JetBrains decompiler
// Type: IScalarModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

public interface IScalarModule
{
  string ScalarModuleID { get; }

  float GetScalar { get; }

  bool CanMove { get; }

  void SetScalar(float t);

  void SetUIRead(bool state);

  void SetUIWrite(bool state);

  bool IsMoving();

  EventDataObsolete<float, float> OnMoving { get; }

  EventDataObsolete<float> OnStop { get; }
}
