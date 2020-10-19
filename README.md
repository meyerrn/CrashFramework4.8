# CrashFramework4.8
This is to demonstrate a problem in .NET Framework 4.8.
Start the program with debugger and open the combobox. Moving the cursor over the items will terminate the programm.
Without debugger, or when attached later, process does not terminate (exception is still thrown but somehow handled).
With .NET Framework 4.7.2, it does not happen.
