// See https://aka.ms/new-console-template for more information
// Generate GUIDs
var techCategoryId = Guid.NewGuid();
var lifestyleCategoryId = Guid.NewGuid();
var travelCategoryId = Guid.NewGuid();

// Print the generated GUIDs
Console.WriteLine($"Tech Category ID: {techCategoryId}");
Console.WriteLine($"Lifestyle Category ID: {lifestyleCategoryId}");
Console.WriteLine($"Travel Category ID: {travelCategoryId}");

// Check if the GUIDs are unique
if (techCategoryId != lifestyleCategoryId && techCategoryId != travelCategoryId && lifestyleCategoryId != travelCategoryId)
{
    Console.WriteLine("All GUIDs are unique.");
}
else
{
    Console.WriteLine("Some GUIDs are not unique.");
}

// Pause the console so you can see the output
Console.WriteLine("Press any key to exit...");
Console.ReadKey();