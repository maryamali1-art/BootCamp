# String Manipulation Exercises
This repository contains a C# console application demonstrating a series of string manipulation exercises.
Each exercise is implemented as a static method in the `StringFunctions` class and showcased in `Program.cs`.

## Table of Contents
1. [Description](#description)
2. [Features](#features)
3. [Prerequisites](#prerequisites)
4. [Getting Started](#getting-started)
5. [Project Structure](#project-structure)
6. [Usage](#usage)
7. [Exercises Implemented](#exercises-implemented)
8. [Contributing](#contributing)
9. [License](#license)

## Description
This console application provides implementations for common string manipulation tasks, including case conversion, substring extraction, formatting, and validation.

## Features
- Count letters in a string
- Convert strings to upper or lower case
- Check prefixes and suffixes (case-insensitive)
- Validate numeric and alphabetic content
- Capitalize and swap character cases
- Split and join words
- Trim and count whitespace
- Email format validation and masking
- Substring extraction and replacement
- Anagram check
- Digit and letter extraction
- ASCII code conversion
- Duplicate removal in sentences
- File extension extraction
- Newline replacement

## Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)

## Getting Started
1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd <repository-folder>
   ```
2. Build the solution:
   ```bash
   dotnet build BootCamp.sln
   ```

## Project Structure
```
. 
├── BootCamp.sln             # Solution file
├── StringManipulation/      # C# console project
│   ├── Program.cs           # Main entry point demonstrating all exercises
│   ├── StringFunctions.cs   # Implementation of string manipulation methods
│   └── StringManipulation.csproj
├── strings trains.pdf       # Assignment description
└── README.md                # This file
```

## Usage
Run the application to see the output of each exercise:
```bash
dotnet run --project StringManipulation/StringManipulation.csproj
```

## Exercises Implemented
1. Count the number of characters in a string
2. Convert a string to uppercase
3. Convert a string to lowercase
4. Check if a string starts with a given prefix
5. Check if a string ends with a given suffix
6. Check if a string contains only digits
7. Check if a string contains only letters
8. Capitalize the first character of a string
9. Swap the case of each character in a string
10. Split a string into words
11. Join a list of words into a string
12. Remove leading and trailing whitespace from a string
13. Count the number of spaces in a string
14. Check if a string is in email address format
15. Get the first five characters of a string
16. Get the last three characters of a string
17. Replace commas with semicolons in a string
18. Check if two strings are anagrams
19. Find all digits in a string
20. Find all letters in a string
21. Mask an email address (e.g., a***@domain.com)
22. Convert a sentence into a list of ASCII codes
23. Remove duplicate words from a sentence
24. Extract the file extension from a filename
25. Replace newlines with spaces in a string

## Contributing
Contributions are welcome! Feel free to open issues or submit pull requests.

## License
This project is provided for educational purposes. No license is specified.