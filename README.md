# notificationhub-netstandard 1.6

Nuget : https://www.nuget.org/packages/AzureNotificationHub.NETStandard/

## Current progression

|                               | GCM Registration | GCM Registration (T) | Apple Registration | Apple Registration (T) |
|-------------------------------|------------------|----------------------|--------------------|------------------------|
| Create Registration           |         V        |           V          |          V         |                        |
| Update Registration           |         V        |           V          |          V         |                        |
| Create or Update Registration |         V        |           V          |          V         |                        |
| Readall Registration          |         V        |           V          |          V         |                        |
| Direct Send                   |         V        |                      |                    |                        |
| Send native                   |         V        |                      |                    |                        |



|                               | WNS Registration | WNS Registration (T) | MPNS Registration  | MPNS Registration (T)  |  
|-------------------------------|------------------|----------------------|--------------------|------------------------|
| Create Registration           |         V        |           V          |                    |                        |  
| Update Registration           |         V        |           V          |                    |                        |
| Create or Update Registration |         V        |           V          |                    |                        |  
| Readall Registration          |         V        |           V          |                    |                        |
| Direct Send                   |                  |                      |                    |                        |
| Send native                   |                  |                      |                    |                        |




## Basic usage

```csharp
AzureNotificationHubClient ans = new AzureNotificationHubClient(
    "AccesKey", 
    "HubName"
);
```
