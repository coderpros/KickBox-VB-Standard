<img src="https://coderpro.net/media/1024/coderpro_logo_rounded_extra-90x90.webp" align="right" />

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/cloudposse.svg?style=social&label=Follow%20%40coderProNet)](https://twitter.com/coderProNet)
[![GitHub](https://img.shields.io/github/followers/coderpros?label=Follow&style=social)](https://github.com/coderpros)

# KickBox-VB-Standard
> A [KickBox.io](https://kickbox.io) API wrapper for .Net Standard version 4.8 written in VB.Net.


[contributors-shield]: https://img.shields.io/github/contributors/coderpros/KickBox-VB-Standard.svg?style=flat-square
[contributors-url]: https://github.com/coderpros/KickBox-VB-Standard/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/coderpros/KickBox-VB-Standard?style=flat-square
[forks-url]: https://github.com/coderpros/KickBox-VB-Standard/network/members
[stars-shield]: https://img.shields.io/github/stars/coderpros/KickBox-VB-Standard.svg?style=flat-square
[stars-url]: https://github.com/coderpros/KickBox-VB-Standard/stargazers
[issues-shield]: https://img.shields.io/github/issues/coderpros/KickBox-VB-Standard?style=flat-square
[issues-url]: https://github.com/coderpros/KickBox-VB-Standard/issues
[license-shield]: https://img.shields.io/github/license/coderpros/kickbox-asp?style=flat-square
[license-url]: https://github.com/coderpros/KickBox-VB-Standard/blob/master/KickBox.Standard.VB/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/company/coderpros
[twitter-shield]: https://img.shields.io/twitter/follow/coderpronet?style=social
[twitter-follow-url]: https://img.shields.io/twitter/follow/coderpronet?style=social
[github-shield]: https://img.shields.io/github/followers/coderpros?label=Follow&style=social
[github-follow-url]: https://img.shields.io/twitter/follow/coderpronet?style=social

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
