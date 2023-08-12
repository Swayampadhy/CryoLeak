# CryoLeak
----
### About

This C2 contains a RESTful API-driven Team Server written in ASP.NET Core and implants targeting the .NET Framework.
Communication flow in the framework can be defined as below-
![image](https://github.com/Swayampadhy/CryoLeak/assets/37104162/a5b4adac-288d-4613-b1de-9f2167bb3fa2)
The operator will interact with the Team Server via a management API to carry out actions such as listing implants, tasking them, and getting results back.  The implant itself will also talk to the Team Server over its C2 protocol, such as HTTP, to retrieve said tasks and send results back.
Services connecting the user-API to the implant using services made by **Dependency injection**.

### Functionality

Currently the following commands can be executed by the agent -

1. `pwd`                - Print current directory path
2. `cd`                 - Change directory
3. `ls`                 - Print directory contents
4. `mkdir` and `rmdir`  - Create and remove directory
5. `ps`                 - Enumerate processes
6. `whoami`             - Prints current user
7. `shell`              
8. `run`                
9. `execute-assembly`   
10. `make-token`        
11. `rev2self`
12. `steal-token`
13. `self-inject`
14. `remote-inject`
15. `spawn-inject`

