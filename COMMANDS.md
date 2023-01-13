# Solution
dotnet new sln -n CSharpAnswers  

# .gitignore
dotnet new gitignore

# .editorConfig
copied from github dotnet/runtime/.editorconfig

# Add a new project, example
dotnet new console -o ./0024_index_in_select
dotnet sln add ./0024_index_in_select
cd ./0024_index_in_select

# CodeLens
File -> Preferences -> Settings -> csharp.referencesCodeLens.enabled