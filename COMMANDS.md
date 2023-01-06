# Solution
dotnet new sln -n CSharpAnswers  

# .gitignore
dotnet new gitignore

# .editorConfig
copied from github dotnet/runtime/.editorconfig

# Add a new project, example
dotnet new console -o ./0018_enumerable_vs_queryable
dotnet sln add ./0018_enumerable_vs_queryable

# CodeLens
File -> Preferences -> Settings -> csharp.referencesCodeLens.enabled