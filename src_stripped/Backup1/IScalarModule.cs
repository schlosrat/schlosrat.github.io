// Decompiled with JetBrains decompiler
// Type: IScalarModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
