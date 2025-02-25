# CalculatorApp

This is a simple calculator application built using .NET MAUI.

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio Code](https://code.visualstudio.com/)
- [MAUI workload](https://docs.microsoft.com/en-us/dotnet/maui/get-started/installation)

## Getting Started

1. **Clone the repository:**

    ```sh
    git clone https://github.com/yourusername/CalculatorApp.git
    cd CalculatorApp
    ```

2. **Install the MAUI workload:**

    ```sh
    dotnet workload install maui
    ```

3. **Restore the project dependencies:**

    ```sh
    dotnet restore
    ```

4. **Build the project:**

    ```sh
    dotnet build
    ```

5. **Run the project:**

    ```sh
    dotnet run
    ```

## Running in Visual Studio Code

1. **Open the project in Visual Studio Code:**

    ```sh
    code .
    ```

2. **Configure the launch settings:**

    Create a `.vscode/launch.json` file with the following configuration:

    ```json
    {
        "version": "0.2.0",
        "configurations": [
            {
                "name": ".NET MAUI Launch",
                "type": "coreclr",
                "request": "launch",
                "preLaunchTask": "build",
                "program": "${workspaceFolder}/bin/Debug/net6.0/CalculatorApp.dll",
                "args": [],
                "cwd": "${workspaceFolder}",
                "stopAtEntry": false,
                "console": "internalConsole",
                "logging": {
                    "moduleLoad": false
                },
                "internalConsoleOptions": "openOnSessionStart"
            }
        ]
    }
    ```

3. **Run the project:**

    Press `F5` to start debugging the application.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License.