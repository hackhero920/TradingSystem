# TradingSystem

<img src="banner.jpg" alt="Oybab Trading System banner">

Oybab Trading System is an open source **trading system** that support **multiple language** and run in **multiple device** (By windows platform for now).

Imagine if you have some Employees use different languages, but the system and the information inside of system can handle only 1 language. We hopping the system can support every language and there is no limitation or problem with different language for employees and customers. The system support 3 different languages for inside, which mean you can have 3 employees who speak different languages. The system also support unlimited different languages for the UI, which mean you can have any customers who speak different languages.

Basically you could do any trading information in it. 
You could download and install the binary files for free to:
 - Use for Store, Restaurant, Hotel.....etc.
 - Use for Income and expenses and analysis anything.
 - Use for as like a personal tools.
 
You could download the source code and customized it based it [License](https://oybab.net/license.html) to:
 - As a part of your product components.(E.g. The door lock company integrates the card reading program into the system to make a remote door opening system.)
 - As a part of your service.(E.g. The delivery company connect its own service to the system for save, print, and statistics bills.)
 - As a customized tools.

 Currently supported languages(Extendable):
 - 简体中文
 - ئۇيغۇرچە
 - English

Currently supported external device:
 - Thermal printer 58mm & Thermal printer 80mm & Dot-matrix printer (for print bill) & Barcode Printer (for print barcode)
 - Barcode scanner (support scanner which return (Enter / \r) after scan number)
 - IC & ID card reader (read first 10 numbers of public card no for member card)
 - POS Register Price Monitor (for display current bill price to customers)
 - Cash box/Drawbox (support connect with Thermal printer or used alone)
 - Second monitor(display bill info for customers)


# Getting Started


## End User

There are multiple part for this system(Download from Release page):
 - **Server System**: Install on the server machine(could install in the same machine which install client system ). At least Win7 or newer system required.
 - **PC Client**: Install on the client machine(Recommended to install on a device with a keyboard and mouse for the full operation), At least Win XP or newer system required.
 - **Tablet Client**: Install on the client machine(Recommended to install on a Tablet or device with touch screen for quick operation), At least Win XP or newer system required.
 - **Phone Client**: Install on the Phone(For convenient operation.), currently support the newest iOS, Android, UWP system.(Download from App Store)

### Install

 1. Download the newest install package, Install the Server Install Package, It will running as a windows service, It would auto create a new database when first time install. (If you reboot the windows, it will auto running the service as a background).
 2. Install the Client (Recommend the PC Client, because it include the full feature), and run it after install(change the Language and Server IP address to the right server address which you install Server Install Package before you login).
 The default Super Administrator User Name:1000   Password:123456     (Please modify the Password in time)
 3. Start your journey.



## Developer

Before you download the source code and use make sure installed the prerequisites or download the release page and install the binary version of this system first:
 - **.Net 4**: For PC or Tablet Client.
 - **.Net 4.5**: For Server.
 - **Visual C++ 2010 SP1 Redistributable x86**: For Report library and System.Data.SQLite.

### apply

 1. Download the source code and open with Visual Studio.
 2. For developing more fast, the project setting all **bin** or **obj** files created in the Position: Y:\  . So you need to download a Ramdisk tools, create a new partition Y:\  . If you don't want to do that it's fine, but you should remove items like: **<BaseIntermediateOutputPath>**, **<OutputPath>**, **<IntermediateOutputPath>** from every **.csproj** files or **Directory.Build.props** files under the project.
 3. Open solution with Visual Studio and restore all project Nuget Packages.
 4. Although you could download and change the source code but because currently using **DevExpress** component for Reporting, we unable to provide it binary dll files by thire request. we can't also provide any serial number or crack version of dlls. By them request we can only recommend you use [DevExpress Free trail installer](https://www.devexpress.com/products/try/).  But we planning replace the DevExpress Reporting by HTML5 in the future.
 5. Start your journey.
