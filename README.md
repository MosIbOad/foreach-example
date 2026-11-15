# foreach-example

A simple and beginner-friendly C# console application demonstrating how to iterate over an array using a `foreach` loop and perform a case-insensitive string search.

---

## 📌 Overview

This project provides a straightforward example of iterating through a collection of strings in C#. It checks whether a specific target name exists within a predefined array of names and prints an informative message to the console.

---

## 💡 How It Works

1. **Predefined Array:** An array of names (`string[] names`) is initialized with sample data:
   ```csharp
   string[] names = {
       "Aaren", "Lynda", "Maggi",
       "Giovanna", "Neila", "Berkan"
   };
   ```
2. **Search Target:** A target string (`string isim = "berkan"`) is specified in lowercase.
3. **Foreach Loop:** The `foreach` loop iterates over each element in the array:
   ```csharp
   foreach (string searchname in names)
   {
       if (searchname.ToLower() == isim)
           found = true;
   }
   ```
4. **Case-Insensitive Check:** `.ToLower()` is utilized to ensure that casing differences (e.g., `"Berkan"` vs `"berkan"`) do not prevent a match.
5. **Console Output:** Based on the `found` flag, the program notifies the user whether the target name was found in the list.

---

## 🛠️ Requirements

- **.NET SDK:** [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) or higher
- **IDE / Editor:** Visual Studio 2022, Visual Studio Code, or JetBrains Rider

---

## ⚙️ How to Run

### Using the .NET CLI:

1. Open your terminal and navigate to the project directory:
   ```bash
   cd D:\GitHub\foreach-example\foreach-example
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

### Using Visual Studio:

1. Open `foreach-example.sln` in Visual Studio.
2. Press `F5` or click **Start** to run the program.

---

## 🖥️ Expected Output

When running with the default values:

```text
İsmin listede bulundu berkan!
```

---

## 📄 License

This project is created for educational and demonstration purposes. Feel free to use and modify it as needed.
