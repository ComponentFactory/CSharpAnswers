# Solution
dotnet new sln -n CSharpAnswers  

# .gitignore
dotnet new gitignore

# .editorConfig
copied from github dotnet/runtime/.editorconfig

# Add a new project, example
dotnet new console -o ./0026_lambda_expression_property
dotnet sln add ./0026_lambda_expression_property
cd ./0026_lambda_expression_property

# CodeLens
File -> Preferences -> Settings -> csharp.referencesCodeLens.enabled