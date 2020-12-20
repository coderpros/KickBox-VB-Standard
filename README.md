# KickBox-VB-Standard
A [KickBox.io](https://kickbox.io) API wrapper for .Net Standard version 4.8 written in VB.Net.

## How to use

- Create a free account at [Kickbox.io](https://kickbox.io).
- Sign up for an API Key.
- Add your own Kickbox API key when you instantiate the KickBox object.

I've included a test client application in this project, but here is is an elaboration on how to use each of the methods.
*This is included as a NuGet package here: *
### Verify a single email address

```vbnet
Dim kickbox = new KickBoxApi("*** ADD API KEY HERE ***", "https://api.kickbox.com/v2");

Dim verificationResponse1 = Await kickbox.VerifyEmail(new MailAddress("info@coderpro.net"))
                                    .ConfigureAwait(true);
```

### Verify multiple email addresses in a batch.

```vbnet
Dim verificationResponse2 = Await kickbox.VerifyBatch(
                                            mailAddresses: new[]
                                            {
                                              new MailAddress("brandon.osborne@gamil.com"),
                                              new MailAddress("info@coderpro.net")
                                            },
                                            fileName: "test file",
                                            batchVerificationCallback: null)
                                            .ConfigureAwait(false);
```

### Check status of a bulk verification job

```vbnet
Dim verificationResponse3 = Await kickbox.CheckStatus(1234567)
