// Decompiled with JetBrains decompiler
// Type: IConsoleStorage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.IO;

public interface IConsoleStorage
{
  void InitUserID();

  IAsyncWriter WriteAsync(string absFullPath, string data);

  IAsyncReader ReadAsync(string absFullPath);

  bool WriteSync(string absFullPath, string data);

  object ReadSync(string absFullPath);

  bool DirectoryExists(string path);

  void DirectoryDelete(string path);

  void CreateDirectory(string path);

  string[] DirectoryGetFiles(string path, string searchPattern, SearchOption searchOption);

  string[] DirectoryGetFilesName(string path, string searchPattern, SearchOption searchOption);

  bool FileExists(string path);

  void FileDelete(string path);

  void WriteAllText(string path, string contents);

  void WriteAllBytes(string path, byte[] contents);

  string ReadAllText(string filePath);

  byte[] ReadAllBytes(string filePath);

  string[] ReadAllLines(string path);

  string GetFileName(string filePath);

  string GetDirectoryName(string filePath);
}
