using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

MSBuildLocator.RegisterDefaults();

if (args.Length != 2)
{
    Console.Error.WriteLine("Usage: GenDoc <solution file path> <xml output folder>");
    return -1;
}

// Get the first console argument as the solution path
var solutionFilePath = args[0];
if (!File.Exists(solutionFilePath))
{
    Console.Error.WriteLine($"Could not find file {solutionFilePath}");
    return -1;
}

// Get the second console argument as the output folder path
var outputFolderPath = args[1];


// Open the solution and iterate over all projects
var workspace = MSBuildWorkspace.Create();
var solution = await workspace.OpenSolutionAsync(solutionFilePath);
foreach (var project in solution.Projects)
{
    // Create a StreamWriter to write the XML documentation comments to
    await using var writer = new StreamWriter(Path.Combine(outputFolderPath, $"{project.AssemblyName}.xml"));

    writer.WriteLine("<?xml version=\"1.0\"?>");
    writer.WriteLine("<doc>");
    writer.WriteLine("<assembly>");
    writer.WriteLine($"<name>{project.AssemblyName}</name>");
    writer.WriteLine("</assembly>");
    writer.WriteLine("<members>");

    // Iterate over all documents in each project
    foreach (var document in project.Documents)
    {
        // Get the syntax root of the document
        var syntaxTree = await document.GetSyntaxTreeAsync();
        if (syntaxTree == null)
        {
            Console.Error.WriteLine($"Could not get syntax tree for {document.FilePath}");
            continue;
        }

        var root = syntaxTree.GetRoot();

        // Get the semantic model for the document
        var semanticModel = await document.GetSemanticModelAsync();

        // Find all method and class symbols in the document
        var symbols = root.DescendantNodes()
            .Select(node => semanticModel?.GetDeclaredSymbol(node))
            .Where(symbol => symbol != null);

        // Extract XML documentation comments for each symbol
        foreach (var symbol in symbols)
        {
            var documentationXml = symbol?.GetDocumentationCommentXml();
            if (!string.IsNullOrEmpty(documentationXml))
            {
                writer.WriteLine(documentationXml);
            }
        }
    }

    writer.WriteLine("</members>");
    writer.WriteLine("</doc>");
}

return 0;