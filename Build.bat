@echo off

ECHO PayPal Adaptive Payments SDK for .NET
ECHO ======================================

SET VSTOOLS=%VS140COMNTOOLS%
IF "%VSTOOLS%"=="" GOTO :VS_NOT_FOUND

SET IDE_DIR=%VSTOOLS%\..\IDE
SET DEVENV="%IDE_DIR%\devenv.com"
%DEVENV% PayPalAdaptivePaymentsSDK\PayPalAdaptivePaymentsSDK.sln /clean Release
%DEVENV% PayPalAdaptivePaymentsSDK\PayPalAdaptivePaymentsSDK.sln /build Release
GOTO :END

:VS_NOT_FOUND
ECHO Visual Studio 2015 was not found.

:END
