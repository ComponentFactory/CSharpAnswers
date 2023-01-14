# Solution
dotnet new sln -n CSharpAnswers  

# .gitignore
dotnet new gitignore

# .editorConfig
copied from github dotnet/runtime/.editorconfig

# Add a new project, example
dotnet new console -o ./0025_chunk_link_results
dotnet sln add ./0025_chunk_link_results
cd ./0025_chunk_link_results

# CodeLens
File -> Preferences -> Settings -> csharp.referencesCodeLens.enabled