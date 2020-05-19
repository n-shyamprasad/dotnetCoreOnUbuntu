### How I started  .NET Core, C# using VS Code on Ubuntu
Thought to share my experience on .NET Core with VS Code

.NET Core is a free and open-source, managed computer software framework for Windows, Linux, and macOS operating systems. It is a cross-platform successor to .NET Framework.

#### Highlevel tasks...
- Install Ubuntu in my laptop
- Install VS Code
- Insall .NET sdk, core
- Install Git
- I used CLI to create solution, projects
- Finally commit to GitHub

####  In detailed
#### Install Ubuntu in my laptop 
I follwed below links from official ubunu website, these are very simple steps to follow. 

**Create USB bootable disk**

https://ubuntu.com/tutorials/tutorial-create-a-usb-stick-on-windows#10-installation-complete

**Install ubuntu using USB stick.**

https://ubuntu.com/tutorials/tutorial-install-ubuntu-desktop#1-overview

#### Install VS Code
Install VS code using below command

> sudo apt-get install code

Beofe doing that it is good to udpate the local repository packages using below command
> sudo apt-get update

#### Insall .NET sdk, core
If using a Debian flavor of Linux like Ubuntu, run the below wget command to download the DEB archive first

> wget -q https://packages.microsoft.com/config/ubuntu/19.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb

Once finsih downloading, run the below command from the same directory as the .deb package to install .NET Core:
> sudo dpkg -i packages-microsoft-prod.deb

Now install .NET sdk using below command
> sudo apt-get install dotnet-sdk-3.1

#### Install Git
Use below command to install Git
> sudo apt-get install git

#### I used CLI to create solution, projects

Once.NET core is installed you should have access to a command-line tools you can invoke in the terminal called *dotnet*. 
You can easily see what commands are available by typing:
> dotnet - -help

Also you can refer link for more details on CLI
https://docs.microsoft.com/en-us/dotnet/core/tools/

Create Solution
A solution is something we use to keep track of all related projects.
1. Create directory for our solution
> mkdir dotNetCoreApps
cd dotNetCoreApps
2. Below command will create solution
> dot net new sln
3. Create Console application and name it as HelloWorld-app
> dotnet new console -o HelloWorld-app
4. add the project to the solution file
> dotnet sln add HelloWorld-app/HelloWorld-app.csproj
5. Write the code for the project (can check my code)
6. buid the solution using below code
> dotnet build
7. run the project
> dotnet run HelloWorld-app/HelloWorld-app.csproj

 #### Finally commit to GitHub
 Can use below commands to commit to GitHub
 
> git init

> git add README.md

> git commit -m "first commit"
  
> git remote add origin https://github.com/<< your user-id></user-id>>/your- repo .git
  
> git push -u origin master
  


I'm not familiar with Ubuntu / VS code, I'm learning so you can always correct me if any of the above information is not correct.

### Thank you
