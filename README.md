# Logger
Simple C# Logger framework

[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://lbesson.mit-license.org/)
[![Open Source Love svg1](https://badges.frapsoft.com/os/v1/open-source.svg?v=103)](https://github.com/ellerbrock/open-source-badges/)

### How it works

You can log to a file, the console and the Event Log using a helper class called **LogHelper** which can be used to invoke the respective logger based on the parameter passed which is a log target.  Every logger adds their own implementation of the abstract function Log() from the base class Logger.

This design makes adding new log targets easy while keeping the code organized and clean.


You can also instantiate the loggers without the helper using their respective constructors.

* ConsoleLogger()
* FileLogger(string file_path)
* EventLogger()

## Logging to a file
 ```cs
 LogHelper.Log(LogTarget.File, "text to file");
 ```
  By default, the Helper will log your message to a file called Logger.txt that will be located on the same folder the current executable is.

  If you want to log the message to a different file on a different path, you can do so like this:
```cs
FileLogger customPath = new FileLogger("/path/to/customfile.txt");
customPath.Log("test");
 ```

## Logging to the console
 ```cs
LogHelper.Log(LogTarget.Console, "console test");
  ```
## Logging to the event log
 ```cs
logHelper.Log(LogTarget.EventLog, "Event log test");
```