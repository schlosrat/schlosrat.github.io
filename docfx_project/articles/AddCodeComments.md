# How to Add Documenting (XML) Comments to Code
The first thing you need to do if you've not done this already is to fork this GitHub repo. All the changes you make will be made on your local fork. To incorporate them simply use a Pull Request (PR) from your frok to the main branch of this repo. That said, adding documentng comments is a simple process that goes pretty quickly once you get the hang of it.

1. Locate the .cs file in the **src_stripped** folder containg the code to which you'd like to add or modify *documentaition generating comments*. Documentation generating comments are those that begin with a tripple slash (///), and they inform the generation of the XML file, so they include XML tags that enable them to be parsed to generate the XML file.
2. Open that file in the editor of your choice. Note that editing in Visual Studio or other similarly capable coding oriented editors may make the following steps easier and automate generation of some basic comments and structure.
3. Navigate to the start of the method or the definition line for the object you would like to document.
4. Insert a new blank line directly above and start a tripple slash (///) comment. If your editor is a sufficiently smart coding-aware editor it may detect that you've started a tripple slash comment and start you out with some comments, but it may also start you out with some misinformation based on the stripped nature of the cs file. The bare minimum for documentation generating comments is a summary block like this. All you need to do is to populate the /// comment line(s) between the `<summary></summary>` tags with information that summarizes what this object is used for or what this method does.
```cs
    /// <summary>
    /// Your helpful comments documenting what this is used for or what this does go here!
    /// You can have as many lines as you like. Each line defines one paragrah of documentation.
    /// </summary>
```
5. If the code you're adding *documentation generating comments* to is a method that takes arguments you can document them like this example for a method that takes two input arguments: *newPosition* and *newVelocity*.
```cs
    /// <param name="newPosition"></param>
    /// <param name="newVelocity"></param>
```
6. If the code you're adding *documentation generating comments* to is a method that returns a result you can document them like this example for a method that returns a *stateData* object.
```cs
    /// <returns stateData></returns>
```
7. NOTE: All methods in the **src_stripped** folder have been stripped to only `throw null;` consequently, if you're using a code-aware editior it may automatically add a line like this, which **you should delete** as the real code doesn't do this, so it would be incorrect to document it as doing so. DocFx will ignore these lines, but it will also report warnings for them, so please remove them as this aids in making sure the DocFX results are correct.
```cs
    /// <exception cref="NullReferenceException"></exception>
```

Rinse and repeat for as many objects and methods as you would like to add documenting comments to, then create a PR to get your updates into the main branch of this repo.