// Decompiled with JetBrains decompiler
// Type: IAccount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

public interface IAccount
{
  int Index { get; }

  string AccountName { get; }

  string AccountID { get; }

  string OnlineID { get; }

  int Id { get; }

  bool IsSignedIn { get; }

  void Initailize();

  void SignIn();
}
