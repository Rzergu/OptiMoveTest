# OptiMoveTest
Viacheslav Leznovskiy Test App for Optimove
# Startup
Req: 
Docker 4.32.0
VS 2022

How to start:
change ip in connection string at appsettings.json(localhost can produce bugs)

Using package manager console  in VS 2022 exec command: Update-Database -Context CustomerContext (nonautomatic due to lack of time)

containers should be running to update database!

URL for testing:
Server Side - https://localhost:4301/(customers, sended, ..)
Client Angular App - http://localhost:4201/
DB adminer(if you will need it) DBType: PostgreSql, login: postgres, pass: example - http://localhost:8080

The client app doesnt have some additional checking (for example filtering) or super fancy edit forms but I've tried to do as much as I can in 2 days!
Feel free to contact me if you have any questions while checking this test app, thanks!

My Contacts:
 telegram: @VILEZ
 email: lieznovskiy@gmail.com
