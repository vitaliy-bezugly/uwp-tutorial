# UWP Application with WinUI and MVVM

This project is a basic demonstration of a UWP application using WinUI and the MVVM pattern. The application features a navigation sidebar, binding commands, and navigation between pages.

## Project Structure

The application is divided into three main parts:

1. **Views:** These are the pages in your application, represented by XAML files and their corresponding C# code-behind files.

2. **ViewModels:** Each page has a corresponding ViewModel which contains the logic for the page.

3. **Services:** Services are used to perform operations that aren't specific to a ViewModel, such as navigation.

## Features
### Navigation
The application uses a NavigationView for navigation. The NavigationView contains several NavigationViewItems, each representing a page in the application.

The application utilizes an INavigationService interface and a corresponding NavigationService implementation to navigate between pages.

### ViewModel Binding
ViewModels are bound to pages using the DataContext property in XAML.

### Commands
The application uses ICommand properties in the ViewModel to handle user interaction events. These commands are bound to the respective UI elements in the XAML code.

### Binding to Selected Item
The application includes an example of binding a TextBox to a selected item in a ListView.
