# Project7C
a roblox exploit made in WPF VS19
## Welcome to the Project7C!

## Introduction
What is this?
This is a roblox exploit coded in C# + XAML using VS19 .Net Framework

## Methods
This is all the main that gonna be added soon methods
### Injection
```csharp
using KrnlAPI; //on top of all your code
MainAPI.Inject();
```
### Load API
```csharp
MainAPI.Load(); //Load the API to prevent crashing on injection (place under initialzeComponent();)
```
### Execution
```csharp
MainAPI.Execute(textBox1.Text); //Execute all the text in Textbox1 (change with your textbox name)
```
### Auto Attach
```csharp
if (Checkbox1.Checked)
  MainAPI.AutoAttach(true);
else
  MainAPI.AutoAttach(false);
```
## Credits
- wat#4007 Making the API
- All Krnl Dev for the DLL
- Thx to someone who made the docs [Docs](https://sites.google.com/view/krnlapi/documentation)
- Thx to all that are involved to this (if your name does not get putted here)
### License And Copyright
License And Copyright: [License](https://github.com/Zears14/Project7C/blob/main/LICENSE)
- ©2021-present Zears14 and All other involved
