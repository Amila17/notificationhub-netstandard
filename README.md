# notificationhub-netstandard 1.6


## Current progression

|                               | GCM Registration | GCM Registration (T) | Apple Registration | Apple Registration (T) |
|-------------------------------|------------------|----------------------|--------------------|------------------------|
| Create Registration           |         V        |           V          |                    |                        |
| Update Registration           |         V        |           V          |                    |                        |
| Create or Update Registration |         V        |           V          |                    |                        |
| Readall Registration          |         V        |           V          |                    |                        |
|                               |                  |                      |                    |                        |

## Basic usage

```csharp
AzureNotificationHubClient ans = new AzureNotificationHubClient(
    "AccesKey", 
    "HubName"
);
```