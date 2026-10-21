# GestionDesVols — Flight Management Desktop Application

**Windows Forms flight management application written in VB.NET on .NET 8 — role-based access, flight catalogue administration, destination search and seat reservation with automatic receipt generation.**

---

## Table of Contents

- [Project Overview](#project-overview)
- [Context and Problem Statement](#context-and-problem-statement)
- [Project Objectives](#project-objectives)
- [Main Features](#main-features)
- [System Architecture](#system-architecture)
- [Application Modules](#application-modules)
- [User Roles and Access Control](#user-roles-and-access-control)
- [Authentication Flow](#authentication-flow)
- [Data Model and Storage](#data-model-and-storage)
- [Technology Stack](#technology-stack)
- [Project Structure](#project-structure)
- [Installation and Configuration](#installation-and-configuration)
- [Running the Application](#running-the-application)
- [Usage Walkthrough](#usage-walkthrough)
- [Testing and Validation](#testing-and-validation)
- [Current Limitations](#current-limitations)
- [Future Improvements](#future-improvements)
- [Contributors](#contributors)
- [License](#license)
- [Author](#author)

---

## Project Overview

GestionDesVols is a desktop application that manages a small airline flight catalogue. Behind a single login screen it exposes two distinct workspaces:

- an **administration workspace** where flights are created, modified and deleted;
- a **reservation workspace** where a flight is found by destination and a seat is booked for a client, with an automatic receipt file.

The project is a Visual Studio solution written in VB.NET, targeting `net8.0-windows` with Windows Forms. Flights are persisted in a comma-separated file (`vols.csv`) located in the application working directory, and each reservation produces a text receipt next to it. 

## Context and Problem Statement

As an academic project in desktop application design, the project consists in modelling the core workflows of a flight booking desk:

- maintain an up-to-date list of flights (number, destination, departure date and time, available seats, price);
- let a customer-facing agent find a flight quickly by destination;
- book a seat, keep the seat count consistent and produce a receipt for the client;
- separate administrative duties from standard user duties through a role-based login.

GestionDesVols implements these workflows as a single-tier Windows Forms application in which the interface, the business rules and the file-based persistence are colocated, which keeps the solution easy to read and suitable as a teaching reference for VB.NET.

## Project Objectives

1. Provide a role-based login that routes administrators and simple users to their own workspace.
2. Deliver complete create / update / delete management of the flight catalogue.
3. Provide destination-based search with immediate visual feedback.
4. Implement seat reservation with validation and automatic receipt generation.
5. Persist flights and receipts without requiring a database server.
6. Keep the codebase small, readable and consistent with Windows Forms conventions.

## Main Features

| Area | Confirmed capabilities in this repository |
| --- | --- |
| Authentication | Login form with username, password and role selection; empty-field validation; feedback on invalid credentials or role mismatch |
| Role routing | `Admin` role opens the administration workspace; `Utilisateur simple` role opens the reservation workspace |
| Flight administration | Add, modify and delete flights with field validation, grid refresh and CSV persistence |
| Flight search | Case-insensitive destination search with match listing and an explicit "no flight found" message |
| Reservation | Client information capture, seat availability check, seat decrement and receipt generation |
| Receipts | Automatic text receipt per reservation, named `Recu_<flight number>_<ticks>.txt` |
| Persistence | CSV load and save of the flight catalogue (`vols.csv`) in the application working directory |
| Validation | Empty-field checks, row-selection checks, seat availability checks and user feedback through message boxes |

## System Architecture

The application is a classic single-tier desktop program: three Windows Forms and one shared module, all in the same process. During a session the in-memory array exposed by `DataModule` is the single source of truth; the CSV file is the persistence medium between sessions.

```
                        ┌──────────────────────────┐
                        │   Form1 (login screen)   │
                        │  username / password /   │
                        │  role  →  validation     │
                        └────────────┬─────────────┘
                                     │
              role = "Admin"         │        role = "Utilisateur simple"
                                     ▼
                    ┌────────────────────────┐   ┌──────────────────────────┐
                    │       AdminForm        │   │      ReservationForm     │
                    │  Ajouter / Modifier /  │   │  Rechercher / Réserver   │
                    │  Supprimer  (CRUD)     │   │  + génération de reçu    │
                    └───────────┬────────────┘   └────────────┬─────────────┘
                                │                             │
                                ▼                             ▼
                    ┌───────────────────────────────────────────────────────┐
                    │                    DataModule                         │
                    │        vols(99, 4) in memory  ·  compteurVols        │
                    └───────────┬───────────────────────┬───────────────────┘
                                │                       │
                    SauvegarderVols()            ChargerVols()
                                ▼                       ▲
                    ┌───────────────────────────────────────────────────────┐
                    │   vols.csv  (comma-separated, overwritten on save)    │
                    │   Recu_<vol>_<ticks>.txt  (one file per reservation)  │
                    └───────────────────────────────────────────────────────┘
```

Design characteristics confirmed in the code:

- **Startup** — `My Project/Application.myapp` declares `Form1` as the main form, enables visual styles, disables single-instance mode and shuts down after the main form closes. The project file sets `Sub Main` as the startup object.
- **Shared state** — `DataModule` holds the flight array and the row counter as `Public` members, so both forms operate on the same data without a formal model layer.
- **Presentation** — both workspaces display flights in a `DataGridView` that is rebuilt from the array by a refresh routine (`ActualiserDataGridView`).
- **Persistence** — the CSV file is rewritten from scratch on every administrative save; it is read on form load.

## Application Modules

| Component | Type | Responsibility |
| --- | --- | --- |
| `Form1` | Login form | Credential and role entry, validation, routing to the correct workspace |
| `AdminForm` | Administration workspace | Flight create / update / delete over a `DataGridView`, persistence through `DataModule` |
| `ReservationForm` | Reservation workspace | Destination search, client capture, seat booking, receipt generation |
| `DataModule` | Shared module | In-memory flight array, CSV load and save helpers, error reporting |
| `My Project` | Application model | Startup configuration and resources (`Application.myapp`, `Resources.resx`) |

### Administration workspace (`AdminForm`)

- **Ajouter** — validates that the five fields are filled, writes the flight at the first free row, saves the CSV file, refreshes the grid and clears the input boxes.
- **Modifier** — requires a selected row and replaces its values with the contents of the input boxes, then saves and refreshes.
- **Supprimer** — requires a selected row, shifts the following rows up, decrements the counter, saves and refreshes.
- On load, the flight list is read from the CSV file and the five column headers are created.

### Reservation workspace (`ReservationForm`)

- **Rechercher** — validates the destination, clears the result grid and lists every flight whose destination contains the typed text (case-insensitive). A message box reports when nothing matches.
- **Confirmer la réservation** — requires a selected flight and complete client information (last name, first name, telephone), rejects a flight with no remaining seat, decrements the seat count in memory, writes the receipt file and resets the form.

## User Roles and Access Control

Two roles are recognized at login. The role selected in the combo box decides which workspace opens.

| Role | Destination workspace | Confirmed scope |
| --- | --- | --- |
| `Admin` | `AdminForm` | Full flight management: add, modify, delete, refresh |
| `Utilisateur simple` | `ReservationForm` | Destination search, seat reservation and receipt generation |

Accounts are held in two in-memory dictionaries declared in `Form1.vb`. The values below are the demonstration accounts compiled into the source code:

| Role | Username | Password |
| --- | --- | --- |
| `Admin` | `achref` | `123456` |
| `Utilisateur simple` | `achref` | `1234560` |



## Authentication Flow

1. The user enters a username, a password and selects a role.
2. Empty fields are rejected with a message box before any comparison.
3. The credentials are compared with the dictionary that corresponds to the selected role.
4. On success the matching workspace is displayed and the login form is hidden.
5. On failure a message box reports incorrect credentials or an incorrect role.

## Data Model and Storage

A flight is a five-field record, all values stored as strings in a two-dimensional array `vols(99, 4)` — a capacity of **100 flights**, with `compteurVols` tracking the number of used rows.

| Index | UI column | Meaning | Example value |
| --- | --- | --- | --- |
| 0 | Numéro de vol | Flight number | `4` |
| 1 | Destination | Destination city | `paris` |
| 2 | Date/Heure | Departure date and time | `2\3\2025 3:00` |
| 3 | Places disponibles | Available seats | `4` |
| 4 | Prix | Ticket price | `1456` |

**CSV format** — `vols.csv` is comma-separated, contains no header row and is fully rewritten on each save (`SauvegarderVols`). Loading (`ChargerVols`) ignores a missing file and splits each line on the comma character.

```
4,paris,2\3\2025 3:00,4,1456
4,nice,2\3\2025 3:04,60,1200
3,milano,12\6\2025 22:30,5,2300
```

**Receipt format** — one text file per reservation named `Recu_<flight number>_<DateTime.Ticks>.txt`, written in the working directory:

```
Reçu de réservation :
Numéro de vol : 4
Nom du client : Bejaoui Achref
Téléphone : 12345678
Date : 18/10/2026 14:30
```

## Technology Stack

| Layer | Technology |
| --- | --- |
| Language | Visual Basic .NET (VB.NET), `Option Strict On` in generated code |
| Runtime | .NET 8 — `net8.0-windows` |
| UI framework | Windows Forms (WinForms) |
| Application model | VB Application Framework (`My` namespace), `Sub Main` startup |
| Project system | MSBuild SDK-style project (`.vbproj`), Visual Studio 2022 solution (17.11) |
| Storage | CSV text file and plain-text receipts |
| IDE | Visual Studio 2022 with the *.NET desktop development* workload |

## Project Structure

```
Vols/
├── README.md                                  # Project documentation
└── GestionDesVols/
    ├── GestionDesVols.sln                     # Visual Studio solution
    └── GestionDesVols/
        ├── Form1.vb                           # Login and role routing
        ├── Form1.Designer.vb / Form1.resx     # Login form layout
        ├── AdminForm.vb                       # Flight administration (CRUD)
        ├── AdminForm.Designer.vb / .resx      # Administration layout
        ├── ReservationForm.vb                 # Search and reservation
        ├── ReservationForm.Designer.vb / .resx# Reservation layout
        ├── DataModule.vb                      # Shared array + CSV persistence
        ├── ApplicationEvents.vb               # Application-level event hooks
        ├── My Project/                        # Application model and resources
        └── GestionDesVols.vbproj              # SDK-style project file
```


## Installation and Configuration

### Prerequisites

- Windows 10 or Windows 11 — Windows Forms on `net8.0-windows` is Windows-only.
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 with the **.NET desktop development** workload (recommended)

### Setup

1. Clone the repository:

   ```
   git clone https://github.com/Achref-004/Vols.git
   cd Vols
   ```

2. Open `GestionDesVols/GestionDesVols.sln` in Visual Studio 2022.
3. Restore packages and build the solution (`Ctrl+Shift+B`). The project references no external NuGet package.
4. Start the application with `F5`, or from a terminal:

   ```
   dotnet run --project GestionDesVols/GestionDesVols
   ```

**No configuration is required**: no connection string, environment variable or settings file is read. The `vols.csv` file and the receipts are created automatically in the output directory on first use.

## Running the Application

| Method | Command / action |
| --- | --- |
| Visual Studio | Open the solution, set `GestionDesVols` as the startup project, press `F5` |
| .NET CLI | `dotnet run --project GestionDesVols/GestionDesVols` |
| Published binary | `dotnet publish -c Release` then run the produced executable |

At runtime the working directory is the output folder (`bin/Debug/net8.0-windows/` during development), which is where `vols.csv` and the `Recu_*.txt` files are written.

## Usage Walkthrough

**Administrator**

1. Log in with the role `Admin`.
2. Fill in *Numéro de vol*, *Destination*, *Date/Heure*, *Places disponibles* and *Prix*, then click **Ajouter**.
3. Select a row in the grid, then click **Modifier** to replace its values with the contents of the input boxes, or **Supprimer** to remove it.
4. Changes are written to `vols.csv` immediately.

**Standard user**

1. Log in with the role `Utilisateur simple`.
2. Type a destination and click **Rechercher**; matching flights are listed.
3. Select a flight, fill in *Nom*, *Prenom* and *Telephone*, then click **Confirmer la réservation**.
4. A confirmation is displayed and a receipt file is generated in the output folder.

## Testing and Validation


- Login rejects empty fields, unknown credentials and a role that does not match the credentials.
- **Ajouter** with an empty field is rejected; a complete entry appears in the grid and in `vols.csv`.
- **Modifier** and **Supprimer** without a selected row are rejected.
- A modified or deleted flight is reflected in `vols.csv` after the operation.
- Search is case-insensitive and reports when no flight matches the destination.
- Reservation without a selected flight, with an incomplete client form or with a flight at zero seats is rejected.
- A reservation produces a `Recu_*.txt` file containing the flight number, the client and the booking date.
- Reopening the application reloads the flights saved through the administration workspace.

## Current Limitations


- **Fixed capacity**: the catalogue is limited to 100 flights by the array size; adding beyond that raises an unhandled exception.
- **Weak typing**: all fields are stored as strings. Seat counts, prices and dates are neither validated nor parsed on entry, and a non-numeric seat value breaks `Convert.ToInt32` during reservation.
- **Fragile CSV parsing**: the loader splits each line on the comma character, so a comma inside a destination corrupts the record, and a malformed line aborts the whole load.
- **Repository hygiene**: `bin/`, `obj/` and `.vs/` build artifacts are committed and no `.gitignore` is present.
- **Limited robustness**: no global exception handling and no logging beyond the per-operation `Try/Catch` of the data module.
- **Platform**: Windows-only — the `net8.0-windows` target cannot run on Linux or macOS.

## Future Improvements

1. Replace the fixed array and CSV file with a typed `List(Of Vol)` model and a relational database (SQL Server or SQLite) behind a data-access layer.
2. Externalize credentials into configuration and store passwords as salted hashes; introduce a real user table with roles.
3. Add input validation: numeric seats and price, real `DateTime` values, duplicate flight numbers and capacity checks.
4. Persist seat decrements and store reservations as records instead of only generating receipts.
5. Separate the interface from the business rules (service and repository classes) to make the logic unit-testable.

## Contributors

| Contributor | Role |
| --- | --- |
| Bejaoui Achref | Design and development |





## Author

**Achref Bejaoui** — Master's student in Data Science, with a degree in Business Computing.

Areas of interest: Data Science · Data Analytics · Artificial Intelligence · Machine Learning · Power BI · Data Engineering · Backend Engineering

[LinkedIn](https://linkedin.com/in/achref-bejaoui00) · [GitHub](https://github.com/Achref-004)
