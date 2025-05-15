# Discord Rich Presence Control Panel

A Windows Forms application that allows you to easily customize and control your Discord Rich Presence status. Built with C# and the Discord Rich Presence library.

![Discord Rich Presence Example](https://i.imgur.com/example.png)

## Features

- 🎮 Real-time Discord Rich Presence updates
- 🖼️ Custom large image with tooltip text
- 📝 Customizable status and details
- 🔗 Up to 2 clickable buttons with custom URLs
- 👤 Display your Discord avatar and username
- 🔄 Live preview of your presence changes

## Prerequisites

- Windows OS
- .NET Framework 4.7.2
- Discord desktop app installed and running
- A Discord application with Rich Presence enabled

## Setup

1. Download The Code

2. Open the solution in Visual Studio

3. Restore NuGet packages:
   - DiscordRichPresence (v1.2.1.24)
   - Newtonsoft.Json (v13.0.1)

4. Build and run the application

## Usage

1. **Initial Setup**
   - Create a Discord application at [Discord Developer Portal](https://discord.com/developers/applications)
   - Copy your application's Client ID
   - Enter the Client ID in the application

2. **Customizing Your Presence**
   - Set your status text
   - Set details text
   - Configure large image key and tooltip
   - Add up to 2 buttons with custom labels and URLs
   - Click "Update" to see your changes in Discord

3. **Default Values**
   The application comes with default values for testing:
   - Default Client ID
   - Status: "Customizing Presence"
   - Details: "Using RPC Control Panel"
   - Large Image Key: "profile"
   - Two customizable buttons

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Acknowledgments

- [discord-rpc-csharp](https://github.com/Lachee/discord-rpc-csharp) library
- Discord for providing the Rich Presence API

## Support

If you encounter any issues or have questions, please open an issue in the GitHub repository. 