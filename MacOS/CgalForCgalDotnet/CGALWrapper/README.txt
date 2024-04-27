
- You can check the Notes.txt file to get a better picture of what went on.

__
What you need to do, at the very minimum, to get this project to compile in your system:


1) Modify the "Header Search Paths" and "Library Search Paths" in the project "Build Settings" (not in the target "Build Settings"), to fit your system paths.

Example: Change  /opt/homebrew/opt/gmp/include  to  my_system_path_to_gmp/include

Note: You can double-click the value in "Header Search Paths" to get a better editor for the paths.

If you installed all libraries, that this project depends on, using Homebrew, then run the following commands to check their install paths, so that then you can mod "... Search Paths" accordingly:

brew --prefix cgal
brew --prefix boost
brew --prefix gmp
brew --prefix mpfr
brew --prefix eigen



2) Build the target with suffix "dynamic" to create the dynamic-linked library.
Tap "Show in Finder" over the product in "Products" group, to view the output library file.


2.1) Build the target with suffix "static " to create the static-linked library.
Tap "Show in Finder" over the product in "Products" group, to view the output library file.

