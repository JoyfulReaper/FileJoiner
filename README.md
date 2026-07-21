# FileJoiner

FileJoiner is a small Windows Forms utility for combining multiple files into a
single output file. It can join files byte-for-byte, or join plain text files
with a configurable number of new lines between each file.

## Features

- Add multiple files at once.
- Reorder files before joining.
- Remove selected files or clear the full list.
- Choose the output folder and output filename.
- Join all files as raw file content.
- Join text files with optional blank lines between inputs.

## Requirements

- Windows
- .NET 10 SDK with Windows Forms support

The UI project targets `net10.0-windows7.0`. The library project targets
`net10.0`.

## Build

From the repository root:

```powershell
dotnet build FileJoiner.sln
```

## Run

From the repository root:

```powershell
dotnet run --project FileJoinerUI\FileJoinerUI.csproj
```

## Usage

1. Click **Add Files** and select the files to combine.
2. Use the up and down buttons to set the join order.
3. Set the output filename.
4. Optionally click **Set Output Folder**.
5. For plain text files, check **All of my files are plain text files** and set
   the number of new lines to insert between files.
6. Click **Join Files**.

If the output file already exists, the app asks before overwriting it.

## Project Layout

- `FileJoinerLibrary` contains the file joining logic.
- `FileJoinerUI` contains the Windows Forms interface.
- `FileJoiner.sln` is the Visual Studio solution file.

## Development

Run a build before submitting changes:

```powershell
dotnet build FileJoiner.sln
```

The project is licensed under the MIT License. See `LICENSE.md` for details.
