# Solution
dotnet new sln -n CSharpAnswers  

# .gitignore
dotnet new gitignore

# .editorConfig
copied from github dotnet/runtime/.editorconfig

# Add a new project, example
dotnet new console -o ./0010_null_reference_exception
dotnet sln add ./0010_null_reference_exception

# CodeLens
File -> Preferences -> Settings -> csharp.referencesCodeLens.enabled