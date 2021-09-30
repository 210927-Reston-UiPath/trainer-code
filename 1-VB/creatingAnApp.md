# Creating a console app

1. Using the dotnet new command create a new console app in vb
   - Run `dotnet new console --language vb -o <Name of your application>`
   - `--language` is a flag for letting the cli know that you want to use vb syntax
   - `-o` is a flag for letting the cli know that you want that project in a specific folder
2. Create a .gitignore file for ignoring build output
   - Run `dotnet new gitignore`
   - OR you can create your own gitignore file, go to gitignore.io and copy what it gives you in the .gitignore file you just created
3. Run your new app
   - cd into the folder that contains your application
   - run the command `dotnet run`
   - If you get an error `could not find project to run` you're probably in the wrong directory
