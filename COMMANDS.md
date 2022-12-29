# Solution
dotnet new sln -n CSharpAnswers  

# .gitignore
dotnet new gitignore

# .editorConfig
copied from github dotnet/runtime/.editorconfig

# Add a new project, example
dotnet new console -o ./0009_null_coalescing
dotnet sln add ./0009_null_coalescing

# CodeLens
File -> Preferences -> Settings -> csharp.referencesCodeLens.enabled