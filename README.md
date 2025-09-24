
# BarCodeMVC (.NET 8)

BarCodeMVC is a sample ASP.NET Core MVC application that demonstrates how to **generate** and **scan barcodes** using popular .NET libraries like ZXing.Net and BarcodeLib. Built using **.NET 8**, the project offers basic functionality for barcode creation and reading via uploaded images.

---

## 🎯 Features

- ✅ Generate 1D & 2D barcodes (Code128, QR, etc.)
- 📷 Scan/upload barcodes to extract data
- 💡 Preview generated barcodes in browser
- 🖨️ Print barcode directly from the view
- 💾 Save barcode as image file (PNG/JPG)
- 🌐 Clean and responsive Bootstrap UI

---

## 🛠️ Technologies

- ASP.NET Core MVC (.NET 8)
- ZXing.Net / BarcodeLib (NuGet)
- Entity Framework Core (if using DB)
- C#, Razor Pages
- Bootstrap 5

---

## 📦 Getting Started

### 🔧 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022+ or VS Code
- NuGet packages:
  - `ZXing.Net`
  - `BarcodeLib`

### 📥 Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/ahmedhamzarana/BarCodeMVC.git
   cd BarCodeMVC
   ```

2. **Install dependencies**
   Install required NuGet packages in Visual Studio or via CLI:
   ```bash
   dotnet add package ZXing.Net
   dotnet add package BarcodeLib
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

   Open `https://localhost:5001` in your browser.

---

## 🔍 How It Works

- Navigate to `/BarCode/Generate` to create a barcode from text.
- Navigate to `/BarCode/Scan` to upload an image and scan its barcode.
- Barcodes are rendered on-the-fly and can be downloaded or printed.

---

## 📁 Project Structure

```
BarCodeMVC/
├── Controllers/
│   └── BarCodeController.cs
├── Models/
│   └── BarCodeModel.cs
├── Views/
│   └── BarCode/
│       ├── Generate.cshtml
│       ├── Scan.cshtml
├── wwwroot/
│   └── images/, css/, js/
├── Program.cs
├── appsettings.json
└── BarCodeMVC.csproj
```
---

## 🤝 Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

---

## 📸 Screenshot (Optional)

> Add a screenshot of barcode generation and scanning page here.

---

## 📬 Contact

Created by Ahmed Hamza Rana - feel free to reach out!
