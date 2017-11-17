# example-identitymodel-issue
Demonstrates issue with System.IdentityModel.Tokens.Jwt for .net 4.6.1 which I encountered. Here I have two projects with different platforms which depend on `System.IdentityModel.Tokens.Jwt 5.1.4`. 
Project which is .NET Core 2.0 is able to verify that token is valid. Project with .NET 4.6.1 is not able to verify that token is valid.

## Structure
I have three projects in solution:

* `net4561console` is project which is not able to verify token validity.
* `netCore` is project which is able to verify token validity.
* `shared` is project which has resource file with JWT and JWKS. Basicaly both `net461` and `netCore` depend on same JWT and JWKS.

## Steps to reproduce 
1. Clone solution.
2. Open solution in Visual Studio 2017
3. Run `net461console` project in debug mode: `var valid = IsValid(jwtSecurityToken, securityKeys);` should be `false`.
4. Run `netcore` project in debug mode: `var valid = IsValid(jwtSecurityToken, securityKeys);` should be `true`.

Please note that JWT token has expairation time.
