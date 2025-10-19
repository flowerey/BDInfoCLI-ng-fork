# BDInfoCLI-ng-fork

Updated fork of BDInfoCLI-ng that can be compiled on Windows 11, also has some other updates.

Forked from [rokibhasansagar/BDInfoCLI-ng](https://github.com/rokibhasansagar/BDInfoCLI-ng)
→ which was forked from [Ethan930717/BDInfoCLI-ng (kimoji-bdinfo branch)](https://github.com/Ethan930717/BDInfoCLI-ng/tree/kimoji-bdinfo)
→ which originates from [UniqProject/BDInfo](https://github.com/UniqProject/BDInfo)
→ based on the **original** [CinemaSquid BDInfo](https://www.videohelp.com/software/BDInfo)

**Additional sources:** [Tripplesixty/BDInfoCLI](https://github.com/Tripplesixty/BDInfoCLI)

BDInfoCLI-ng-fork is the latest BDInfo (with UHD support) modified for CLI use. It implements an interface similar to BDInfoCLI, built on the latest BDInfo code base with minimal invasive changes for easier maintenance with future BDInfo updates.

## Usage

```bash
Usage: BDInfo.exe <BD_PATH> [REPORT_DEST]

BD_PATH may be a directory containing a BDMV folder or a BluRay ISO file.
REPORT_DEST is the folder the BDInfo report is written to. If not given, 
the report will be written to BD_PATH. REPORT_DEST is required if BD_PATH is an ISO file.

Options:
  -?, --help, -h             Print help options
  -l, --list                 Print the list of playlists
  -m, --mpls=VALUE           Comma separated list of playlists to scan
  -w, --whole                Scan whole disc - every playlist
  -v, --version              Print the version
```

### Examples

```bash
# Display playlists, prompt user to select, output report to same path
BDInfo.exe BD_PATH

# Output report in a specified folder
BDInfo.exe BD_PATH REPORT_OUTPUT_DIR

# Display list of playlists only
BDInfo.exe -l BD_PATH

# Scan the whole disc (every playlist), non-interactive
BDInfo.exe -w BD_PATH

# Scan selected playlists, non-interactive
BDInfo.exe -m 00006.MPLS,00009.MPLS BD_PATH

# Display BDInfo version
BDInfo.exe -v
```

## Windows

### Requirements

* Windows Vista, 7, or higher
* .NET Framework 4.8 or higher
* Source Code
* NuGet

BDInfoCLI-ng can be built using the free [Microsoft Visual Studio Community Edition](https://visualstudio.microsoft.com/vs/community/).

Steps:

1. Install Visual Studio.
2. Open `BDInfo.sln`.
3. Build the project.

## Linux

BDInfoCLI-ng can be built and run using [Mono](https://www.mono-project.com/).

### Recommended: Using Docker

Using Docker avoids modifying your system with Mono. The included `bdinfo` wrapper script in the `scripts` directory handles mounting directories automatically. The first run downloads the container image; subsequent runs are faster.

```bash
./bdinfo --help

# Display playlists, prompt user to select, output report to same path
./bdinfo BD_PATH

# Output report in a specified folder
./bdinfo BD_PATH REPORT_OUTPUT_DIR
```

Alternatively, run the Docker container manually:

```bash
# Without report destination
docker run --rm -it -v <BD_PATH>:/mnt/bd fr3akyphantom/bdinfocli-ng /mnt/bd

# With report destination
docker run --rm -it -v <BD_PATH>:/mnt/bd -v <REPORT_DEST>:/mnt/report fr3akyphantom/bdinfocli-ng /mnt/bd /mnt/report
```

Without Docker, you can build and run BDInfoCLI-ng manually with Mono (see Dockerfile for reference).

## Mac

The Linux Docker instructions should also work on macOS, but this has not been tested.
